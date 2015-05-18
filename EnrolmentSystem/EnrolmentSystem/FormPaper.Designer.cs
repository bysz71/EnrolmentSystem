namespace EnrolmentSystemUI
{
    partial class FormPaper
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
            this.labelTopic = new System.Windows.Forms.Label();
            this.textBoxCode = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxCoordinator = new System.Windows.Forms.TextBox();
            this.listBoxStudents = new System.Windows.Forms.ListBox();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTopic
            // 
            this.labelTopic.AutoSize = true;
            this.labelTopic.Location = new System.Drawing.Point(13, 13);
            this.labelTopic.Name = "labelTopic";
            this.labelTopic.Size = new System.Drawing.Size(93, 17);
            this.labelTopic.TabIndex = 0;
            this.labelTopic.Text = "Paper Details";
            // 
            // textBoxCode
            // 
            this.textBoxCode.Location = new System.Drawing.Point(16, 34);
            this.textBoxCode.Name = "textBoxCode";
            this.textBoxCode.Size = new System.Drawing.Size(109, 22);
            this.textBoxCode.TabIndex = 1;
            this.textBoxCode.ReadOnly = true;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(169, 34);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(348, 22);
            this.textBoxName.TabIndex = 2;
            this.textBoxName.ReadOnly = true;
            // 
            // textBoxCoordinator
            // 
            this.textBoxCoordinator.Location = new System.Drawing.Point(555, 34);
            this.textBoxCoordinator.Name = "textBoxCoordinator";
            this.textBoxCoordinator.Size = new System.Drawing.Size(213, 22);
            this.textBoxCoordinator.TabIndex = 3;
            this.textBoxCoordinator.ReadOnly = true;
            // 
            // listBoxStudents
            // 
            this.listBoxStudents.FormattingEnabled = true;
            this.listBoxStudents.ItemHeight = 16;
            this.listBoxStudents.Location = new System.Drawing.Point(16, 110);
            this.listBoxStudents.Name = "listBoxStudents";
            this.listBoxStudents.Size = new System.Drawing.Size(752, 276);
            this.listBoxStudents.TabIndex = 4;
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Location = new System.Drawing.Point(661, 436);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(75, 23);
            this.buttonConfirm.TabIndex = 5;
            this.buttonConfirm.Text = "Confirm";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // FormPaper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 488);
            this.Controls.Add(this.buttonConfirm);
            this.Controls.Add(this.listBoxStudents);
            this.Controls.Add(this.textBoxCoordinator);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxCode);
            this.Controls.Add(this.labelTopic);
            this.Name = "FormPaper";
            this.Text = "FormPaper";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTopic;
        private System.Windows.Forms.TextBox textBoxCode;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxCoordinator;
        private System.Windows.Forms.ListBox listBoxStudents;
        private System.Windows.Forms.Button buttonConfirm;
    }
}