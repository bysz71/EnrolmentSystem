namespace EnrolmentSystemUI
{
    partial class FormStudent
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
            this.labelName = new System.Windows.Forms.Label();
            this.labelId = new System.Windows.Forms.Label();
            this.labelBirthday = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.textBoxBirthday = new System.Windows.Forms.TextBox();
            this.richTextBoxAddress = new System.Windows.Forms.RichTextBox();
            this.listBoxPapers = new System.Windows.Forms.ListBox();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTopic
            // 
            this.labelTopic.AutoSize = true;
            this.labelTopic.Location = new System.Drawing.Point(12, 9);
            this.labelTopic.Name = "labelTopic";
            this.labelTopic.Size = new System.Drawing.Size(104, 17);
            this.labelTopic.TabIndex = 0;
            this.labelTopic.Text = "Student Details";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(62, 65);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(45, 17);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Name";
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(62, 151);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(19, 17);
            this.labelId.TabIndex = 2;
            this.labelId.Text = "Id";
            // 
            // labelBirthday
            // 
            this.labelBirthday.AutoSize = true;
            this.labelBirthday.Location = new System.Drawing.Point(62, 236);
            this.labelBirthday.Name = "labelBirthday";
            this.labelBirthday.Size = new System.Drawing.Size(60, 17);
            this.labelBirthday.TabIndex = 3;
            this.labelBirthday.Text = "Birthday";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(62, 322);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(60, 17);
            this.labelAddress.TabIndex = 4;
            this.labelAddress.Text = "Address";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(65, 99);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(156, 22);
            this.textBoxName.TabIndex = 5;
            this.textBoxName.ReadOnly = true;
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(65, 187);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(156, 22);
            this.textBoxId.TabIndex = 6;
            this.textBoxId.ReadOnly = true;
            // 
            // textBoxBirthday
            // 
            this.textBoxBirthday.Location = new System.Drawing.Point(65, 276);
            this.textBoxBirthday.Name = "textBoxBirthday";
            this.textBoxBirthday.Size = new System.Drawing.Size(156, 22);
            this.textBoxBirthday.TabIndex = 7;
            this.textBoxBirthday.ReadOnly = true;
            // 
            // richTextBoxAddress
            // 
            this.richTextBoxAddress.Location = new System.Drawing.Point(65, 370);
            this.richTextBoxAddress.Name = "richTextBoxAddress";
            this.richTextBoxAddress.Size = new System.Drawing.Size(156, 96);
            this.richTextBoxAddress.TabIndex = 8;
            this.richTextBoxAddress.Text = "";
            this.richTextBoxAddress.ReadOnly = true;
            // 
            // listBoxPapers
            // 
            this.listBoxPapers.FormattingEnabled = true;
            this.listBoxPapers.ItemHeight = 16;
            this.listBoxPapers.Location = new System.Drawing.Point(336, 99);
            this.listBoxPapers.Name = "listBoxPapers";
            this.listBoxPapers.Size = new System.Drawing.Size(424, 292);
            this.listBoxPapers.TabIndex = 9;
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Location = new System.Drawing.Point(670, 442);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(75, 23);
            this.buttonConfirm.TabIndex = 10;
            this.buttonConfirm.Text = "Confirm";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // FormStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 502);
            this.Controls.Add(this.buttonConfirm);
            this.Controls.Add(this.listBoxPapers);
            this.Controls.Add(this.richTextBoxAddress);
            this.Controls.Add(this.textBoxBirthday);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.labelBirthday);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelTopic);
            this.Name = "FormStudent";
            this.Text = "FormStudent";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTopic;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Label labelBirthday;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.TextBox textBoxBirthday;
        private System.Windows.Forms.RichTextBox richTextBoxAddress;
        private System.Windows.Forms.ListBox listBoxPapers;
        private System.Windows.Forms.Button buttonConfirm;
    }
}