using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EnrolmentSystemModel;

namespace EnrolmentSystemUI
{
    public partial class FormPaper : Form
    {
        private University _university;
        private string _code;

        public FormPaper(University university , string code)
        {
            InitializeComponent();
            _university = university;
            _code = code;
            LoadComponent();
        }

        private void LoadComponent()
        {
            textBoxCode.Text = _university.PaperDictionary[_code].Code;
            textBoxName.Text = _university.PaperDictionary[_code].Name;
            textBoxCoordinator.Text = _university.PaperDictionary[_code].Coordinator;
            LoadListBox();
        }

        private void LoadListBox()
        {
            foreach (string str in _university.PaperDictionary[_code].StudentSet)
            {
                listBoxStudents.Items.Add(str + "\t" + _university.StudentDictionary[str].Name);
            }
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
