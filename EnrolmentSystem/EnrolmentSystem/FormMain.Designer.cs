namespace EnrolmentSystemUI
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.fileMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.appendFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.makeupFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paperListBox = new System.Windows.Forms.ListBox();
            this.studentListBox = new System.Windows.Forms.ListBox();
            this.labelPaperList = new System.Windows.Forms.Label();
            this.labelStudentList = new System.Windows.Forms.Label();
            this.buttonAddPaper = new System.Windows.Forms.Button();
            this.buttonAddStudent = new System.Windows.Forms.Button();
            this.fileMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileMenuStrip
            // 
            this.fileMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.fileMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.fileMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.fileMenuStrip.Name = "fileMenuStrip";
            this.fileMenuStrip.Size = new System.Drawing.Size(1051, 28);
            this.fileMenuStrip.TabIndex = 0;
            this.fileMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileToolStripMenuItem,
            this.saveFileToolStripMenuItem,
            this.appendFileToolStripMenuItem,
            this.makeupFileToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(175, 24);
            this.openFileToolStripMenuItem.Text = "Open file";
            this.openFileToolStripMenuItem.Click += new System.EventHandler(this.openFileToolStripMenuItem_Click);
            // 
            // saveFileToolStripMenuItem
            // 
            this.saveFileToolStripMenuItem.Name = "saveFileToolStripMenuItem";
            this.saveFileToolStripMenuItem.Size = new System.Drawing.Size(175, 24);
            this.saveFileToolStripMenuItem.Text = "Save file";
            this.saveFileToolStripMenuItem.Click += new System.EventHandler(this.saveFileToolStripMenuItem_Click);
            // 
            // appendFileToolStripMenuItem
            // 
            this.appendFileToolStripMenuItem.Name = "appendFileToolStripMenuItem";
            this.appendFileToolStripMenuItem.Size = new System.Drawing.Size(175, 24);
            this.appendFileToolStripMenuItem.Text = "Append File";
            this.appendFileToolStripMenuItem.Click += new System.EventHandler(this.appendFileToolStripMenuItem_Click);
            // 
            // makeupFileToolStripMenuItem
            // 
            this.makeupFileToolStripMenuItem.Name = "makeupFileToolStripMenuItem";
            this.makeupFileToolStripMenuItem.Size = new System.Drawing.Size(175, 24);
            this.makeupFileToolStripMenuItem.Text = "Makeup file";
            this.makeupFileToolStripMenuItem.Click += new System.EventHandler(this.makeupFileToolStripMenuItem_Click);
            // 
            // paperListBox
            // 
            this.paperListBox.FormattingEnabled = true;
            this.paperListBox.ItemHeight = 16;
            this.paperListBox.Location = new System.Drawing.Point(63, 87);
            this.paperListBox.Name = "paperListBox";
            this.paperListBox.Size = new System.Drawing.Size(283, 340);
            this.paperListBox.TabIndex = 1;
            this.paperListBox.SelectedIndexChanged += new System.EventHandler(this.paperListBox_SelectedIndexChanged);
            // 
            // studentListBox
            // 
            this.studentListBox.FormattingEnabled = true;
            this.studentListBox.ItemHeight = 16;
            this.studentListBox.Location = new System.Drawing.Point(543, 87);
            this.studentListBox.Name = "studentListBox";
            this.studentListBox.Size = new System.Drawing.Size(289, 340);
            this.studentListBox.TabIndex = 2;
            this.studentListBox.SelectedIndexChanged += new System.EventHandler(this.studentListBox_SelectedIndexChanged);
            // 
            // labelPaperList
            // 
            this.labelPaperList.AutoSize = true;
            this.labelPaperList.Location = new System.Drawing.Point(63, 64);
            this.labelPaperList.Name = "labelPaperList";
            this.labelPaperList.Size = new System.Drawing.Size(76, 17);
            this.labelPaperList.TabIndex = 3;
            this.labelPaperList.Text = "Paper List:";
            // 
            // labelStudentList
            // 
            this.labelStudentList.AutoSize = true;
            this.labelStudentList.Location = new System.Drawing.Point(543, 63);
            this.labelStudentList.Name = "labelStudentList";
            this.labelStudentList.Size = new System.Drawing.Size(87, 17);
            this.labelStudentList.TabIndex = 4;
            this.labelStudentList.Text = "Student List:";
            // 
            // buttonAddPaper
            // 
            this.buttonAddPaper.Location = new System.Drawing.Point(373, 108);
            this.buttonAddPaper.Name = "buttonAddPaper";
            this.buttonAddPaper.Size = new System.Drawing.Size(120, 23);
            this.buttonAddPaper.TabIndex = 5;
            this.buttonAddPaper.Text = "Add Paper";
            this.buttonAddPaper.UseVisualStyleBackColor = true;
            this.buttonAddPaper.Click += new System.EventHandler(this.buttonAddPaper_Click);
            // 
            // buttonAddStudent
            // 
            this.buttonAddStudent.Location = new System.Drawing.Point(857, 108);
            this.buttonAddStudent.Name = "buttonAddStudent";
            this.buttonAddStudent.Size = new System.Drawing.Size(120, 23);
            this.buttonAddStudent.TabIndex = 6;
            this.buttonAddStudent.Text = "Add Student";
            this.buttonAddStudent.UseVisualStyleBackColor = true;
            this.buttonAddStudent.Click += new System.EventHandler(this.buttonAddStudent_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 520);
            this.Controls.Add(this.buttonAddStudent);
            this.Controls.Add(this.buttonAddPaper);
            this.Controls.Add(this.labelStudentList);
            this.Controls.Add(this.labelPaperList);
            this.Controls.Add(this.studentListBox);
            this.Controls.Add(this.paperListBox);
            this.Controls.Add(this.fileMenuStrip);
            this.MainMenuStrip = this.fileMenuStrip;
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.fileMenuStrip.ResumeLayout(false);
            this.fileMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.MenuStrip fileMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem appendFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem makeupFileToolStripMenuItem;
        private System.Windows.Forms.ListBox paperListBox;
        private System.Windows.Forms.ListBox studentListBox;
        private System.Windows.Forms.Label labelPaperList;
        private System.Windows.Forms.Label labelStudentList;
        private System.Windows.Forms.Button buttonAddPaper;
        private System.Windows.Forms.Button buttonAddStudent;

        
    }
}

