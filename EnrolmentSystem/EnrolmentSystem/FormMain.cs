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

            return true;
        }

        private void PaperListInitiate()
        {
            string item = "";
            foreach(KeyValuePair<String,EnrolmentSystemModel.Paper> entry in _university.PaperDictionary){
                item = entry.Value.Code + "\t" + entry.Value.Name;
                paperListBox.Items.Add(item);
            }
        }

        private void StudentListInitiate()
        {
            string item = "";
            foreach (KeyValuePair<String, EnrolmentSystemModel.Student> entry in _university.StudentDictionary)
            {
                item = entry.Value.Id + "\t" + entry.Value.Name;
                studentListBox.Items.Add(item);
            }
        }

        private void studentListBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            string[] temp = studentListBox.SelectedItem.ToString().Split('\t');
            FormStudent formStudent = new FormStudent(_university,temp[0]);
            formStudent.ShowDialog();
        }

        private void paperListBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            string[] temp = paperListBox.SelectedItem.ToString().Split('\t');
            FormPaper formPaper = new FormPaper(_university, temp[0]);
            formPaper.ShowDialog();
        }

        private void makeupFileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
