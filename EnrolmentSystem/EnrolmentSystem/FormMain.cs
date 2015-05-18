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
                UniversityInitiate(_fileName);
            }


        }

        private void UniversityInitiate(string filename)
        {
            _university = new EnrolmentSystemModel.University();
            System.IO.StreamReader streamReader = new System.IO.StreamReader(filename);

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
                if (temp[0] == "paper")
                {
                    var paper = new EnrolmentSystemModel.Paper(temp[1],temp[2],temp[3]);
                    string[] member = streamReader.ReadLine().Split('_');
                    for(int i = 1 ; i<member.Length; i++){
                        if(member[i]!=null&&member[i]!="")
                            paper.AddStudent(member[i]);
                    }
                    
                }
                else if (temp[0] == "student")
                {
                    var student = new EnrolmentSystemModel.Student(temp[1], temp[2], temp[3], temp[4]);
                    MessageBox.Show("Student--id is " + student.Id + " name is " + student.Name + " birthday is " + student.BirthDay + "\naddress is " + student.Address);
                }
                else
                {
                    continue;
                }
                
            }

        }


        private void makeupFileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
