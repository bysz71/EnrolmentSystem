using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnrolmentSystemUI
{
    public partial class FormMain : Form
    {
        private string _fileName;

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


        }

        private void makeupFileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
