using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using EnrolmentSystemModel;

namespace EnrolmentSystemUI
{
    public partial class FormMain : Form
    {
        private string _fileName;
        private EnrolmentSystemModel.University _university;

        public FormMain()
        {
            InitializeComponent();
            _fileName = "";
        }

        OpenFileDialog openFileDialog = new OpenFileDialog();
        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                _fileName = openFileDialog.FileName;
            }

            if (_fileName != "")
            {
                if (UniversityInitiate(_fileName))
                {
                    PaperListInitiate();
                    StudentListInitiate();
                }
            }

           

        }

        private bool UniversityInitiate(string filename)
        {
            _university = new EnrolmentSystemModel.University();
            System.IO.StreamReader streamReader = new System.IO.StreamReader(filename);

            if (streamReader.ReadLine() != "--university database--")
            {
                MessageBox.Show("Invalid file, please choose a university database file.");
                return false;
            }

            string line = "";
            while (streamReader.Peek() >= 0)
            {
                line = streamReader.ReadLine();
                string[] temp = line.Split('_');

                //add paper or student to university object base on line header
                if (temp[0] == "paper")
                {
                    var paper = new EnrolmentSystemModel.Paper(temp[1],temp[2],temp[3]);
                    string[] member = streamReader.ReadLine().Split('_');
                    for(int i = 1 ; i<member.Length; i++){
                        if(member[i]!=null&&member[i]!="")
                            paper.AddStudent(member[i]);
                    }
                    _university.AddPaper(paper);
                }
                else if (temp[0] == "student")
                {
                    var student = new EnrolmentSystemModel.Student(temp[1], temp[2], temp[3], temp[4]);
                    _university.AddStudent(student);
                }
                else
                {
                    continue;
                }
            }

            streamReader.Close();
            return true;
        }

        private void PaperListInitiate()
        {
            paperListBox.Items.Clear();
            string item = "";
            foreach(KeyValuePair<String,EnrolmentSystemModel.Paper> entry in _university.PaperDictionary){
                item = entry.Value.Code + "\t" + entry.Value.Name;
                paperListBox.Items.Add(item);
            }
        }

        private void StudentListInitiate()
        {
            studentListBox.Items.Clear();
            string item = "";
            foreach (KeyValuePair<String, EnrolmentSystemModel.Student> entry in _university.StudentDictionary)
            {
                item = entry.Value.Id + "\t" + entry.Value.Name;
                studentListBox.Items.Add(item);
            }
        }

        private void studentListBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (studentListBox.SelectedItem != null)
            {
                string[] temp = studentListBox.SelectedItem.ToString().Split('\t');
                FormStudent formStudent = new FormStudent(_university, temp[0]);
                formStudent.ShowDialog();
            }
        }

        private void paperListBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (paperListBox.SelectedItem != null)
            {
                string[] temp = paperListBox.SelectedItem.ToString().Split('\t');
                FormPaper formPaper = new FormPaper(_university, temp[0]);
                formPaper.ShowDialog();
            }
        }

        private void makeupFileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void buttonAddPaper_Click(object sender, EventArgs e)
        {
            FormAddPaper formAddPaper = new FormAddPaper(_university);
            formAddPaper.ShowDialog();
            PaperListInitiate();
        }

        private void buttonAddStudent_Click(object sender, EventArgs e)
        {
            FormAddStudent formAddStudent = new FormAddStudent(_university);
            formAddStudent.ShowDialog();
            StudentListInitiate();
        }

        private void saveFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("aaa");
            SaveFile();

        }

        private void SaveFile(string path = "")
        {
            if (path == "")
                path = _fileName;

            FileStream fs = File.Create(path);
            StreamWriter writer = new StreamWriter(fs);

            writer.WriteLine("--university database--");

            foreach (KeyValuePair<string, Paper> entry in _university.PaperDictionary)
            {
                writer.WriteLine("paper_" + entry.Value.Code + "_" + entry.Value.Name + "_" + entry.Value.Coordinator);
                string temp = "member_";
                List<string> tempList = new List<string>();
                foreach (string str in _university.PaperDictionary[entry.Key].StudentSet)
                {
                    tempList.Add(str);
                }
                string[] tempArray = tempList.ToArray();
                temp = temp + String.Join("_", tempArray);
                writer.WriteLine(temp);
            }

            foreach (KeyValuePair<string, Student> entry in _university.StudentDictionary)
            {
                writer.WriteLine("student_" + entry.Value.Id + "_" + entry.Value.Name + "_" + entry.Value.BirthDay + "_" + entry.Value.Address);
            }


            writer.Close();
            fs.Close();
        }

        private void appendFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string _appendFileName = ofd.FileName;
                System.IO.StreamReader streamReader = new System.IO.StreamReader(_appendFileName);

                if (streamReader.ReadLine() != "--university database--")
                {
                    MessageBox.Show("Invalid file, please choose a university database file.");
                    return;
                }

                string line = "";
                while (streamReader.Peek() >= 0)
                {
                    line = streamReader.ReadLine();
                    string[] temp = line.Split('_');

                    //add paper or student to university object base on line header
                    if (temp[0] == "paper")
                    {
                        var paper = new EnrolmentSystemModel.Paper(temp[1], temp[2], temp[3]);
                        string[] member = streamReader.ReadLine().Split('_');
                        for (int i = 1; i < member.Length; i++)
                        {
                            if (member[i] != null && member[i] != "")
                                paper.AddStudent(member[i]);
                        }
                        _university.AddPaper(paper);
                    }
                    else if (temp[0] == "student")
                    {
                        var student = new EnrolmentSystemModel.Student(temp[1], temp[2], temp[3], temp[4]);
                        _university.AddStudent(student);
                    }
                    else
                    {
                        continue;
                    }
                }

            }

            PaperListInitiate();
            StudentListInitiate();
        }
    }
}
