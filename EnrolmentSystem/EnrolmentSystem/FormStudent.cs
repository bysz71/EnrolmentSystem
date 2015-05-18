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
    public partial class FormStudent : Form
    {
        private EnrolmentSystemModel.University _university;
        string _id;

        public FormStudent(EnrolmentSystemModel.University university , string id)
        {
            InitializeComponent();
            _university = university;
            _id = id;
            LoadComponent();

        }

        private void LoadComponent()
        {
            textBoxName.Text = _university.StudentDictionary[_id].Name;
            textBoxId.Text = _university.StudentDictionary[_id].Id;
            textBoxBirthday.Text = _university.StudentDictionary[_id].BirthDay;
            richTextBoxAddress.Text = _university.StudentDictionary[_id].Address;
            LoadListBox();
        }

        private void LoadListBox()
        {
            HashSet<string> listContainer = new HashSet<string>();
            foreach (KeyValuePair<string, Paper> entry in _university.PaperDictionary)
            {
                if (entry.Value.StudentSet.Contains(_id))
                {
                    listBoxPapers.Items.Add(entry.Value.Code + "\t" + entry.Value.Name);
                }
            }
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
