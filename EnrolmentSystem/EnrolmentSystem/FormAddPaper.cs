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
    public partial class FormAddPaper : Form
    {
        private University _university;
        private Paper _paper;

        public FormAddPaper(University university)
        {
            InitializeComponent();
            _university = university;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text == "" || textBoxCode.Text == "" || textBoxCoordinator.Text == "")
            {
                MessageBox.Show("Error: Please fill all the blanks");
                return;
            }

            _paper = new Paper(textBoxCode.Text, textBoxName.Text, textBoxCoordinator.Text);
            if (_university.AddPaper(_paper))
            {
                MessageBox.Show("Added");
                this.Close();
            }
            else
            {
                MessageBox.Show("Existed, failed");
            }
        }



        
    }
}
