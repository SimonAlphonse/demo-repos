namespace Hello
{
    partial class FormHello
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
            this.panelBorder = new System.Windows.Forms.Panel();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.radioButtonAdult = new System.Windows.Forms.RadioButton();
            this.dateTimePickerDob = new System.Windows.Forms.DateTimePicker();
            this.labelDob = new System.Windows.Forms.Label();
            this.comboBoxUserName = new System.Windows.Forms.ComboBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.labelMessage = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelUserName = new System.Windows.Forms.Label();
            this.panelBorder.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBorder
            // 
            this.panelBorder.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelBorder.Controls.Add(this.buttonSubmit);
            this.panelBorder.Controls.Add(this.radioButtonAdult);
            this.panelBorder.Controls.Add(this.dateTimePickerDob);
            this.panelBorder.Controls.Add(this.labelDob);
            this.panelBorder.Controls.Add(this.comboBoxUserName);
            this.panelBorder.Controls.Add(this.textBoxEmail);
            this.panelBorder.Controls.Add(this.textBoxLastName);
            this.panelBorder.Controls.Add(this.textBoxFirstName);
            this.panelBorder.Controls.Add(this.labelMessage);
            this.panelBorder.Controls.Add(this.labelLastName);
            this.panelBorder.Controls.Add(this.labelFirstName);
            this.panelBorder.Controls.Add(this.labelEmail);
            this.panelBorder.Controls.Add(this.labelUserName);
            this.panelBorder.Location = new System.Drawing.Point(11, 8);
            this.panelBorder.Name = "panelBorder";
            this.panelBorder.Size = new System.Drawing.Size(389, 242);
            this.panelBorder.TabIndex = 2;
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(279, 204);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(76, 25);
            this.buttonSubmit.TabIndex = 10;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // radioButtonAdult
            // 
            this.radioButtonAdult.AutoSize = true;
            this.radioButtonAdult.Enabled = false;
            this.radioButtonAdult.Location = new System.Drawing.Point(295, 131);
            this.radioButtonAdult.Name = "radioButtonAdult";
            this.radioButtonAdult.Size = new System.Drawing.Size(60, 21);
            this.radioButtonAdult.TabIndex = 9;
            this.radioButtonAdult.TabStop = true;
            this.radioButtonAdult.Text = "Adult";
            this.radioButtonAdult.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerDob
            // 
            this.dateTimePickerDob.CalendarFont = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerDob.Location = new System.Drawing.Point(120, 129);
            this.dateTimePickerDob.Name = "dateTimePickerDob";
            this.dateTimePickerDob.Size = new System.Drawing.Size(161, 23);
            this.dateTimePickerDob.TabIndex = 8;
            // 
            // labelDob
            // 
            this.labelDob.AutoSize = true;
            this.labelDob.Location = new System.Drawing.Point(19, 131);
            this.labelDob.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDob.Name = "labelDob";
            this.labelDob.Size = new System.Drawing.Size(90, 17);
            this.labelDob.TabIndex = 6;
            this.labelDob.Text = "Date of birth";
            // 
            // comboBoxUserName
            // 
            this.comboBoxUserName.Enabled = false;
            this.comboBoxUserName.FormattingEnabled = true;
            this.comboBoxUserName.Location = new System.Drawing.Point(120, 167);
            this.comboBoxUserName.Name = "comboBoxUserName";
            this.comboBoxUserName.Size = new System.Drawing.Size(235, 25);
            this.comboBoxUserName.TabIndex = 5;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(120, 91);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(236, 23);
            this.textBoxEmail.TabIndex = 3;
            this.textBoxEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(120, 53);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(236, 23);
            this.textBoxLastName.TabIndex = 1;
            this.textBoxLastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(120, 18);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(236, 23);
            this.textBoxFirstName.TabIndex = 0;
            this.textBoxFirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.Location = new System.Drawing.Point(17, 207);
            this.labelMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(73, 17);
            this.labelMessage.TabIndex = 1;
            this.labelMessage.Text = "[Message]";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(19, 56);
            this.labelLastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(73, 17);
            this.labelLastName.TabIndex = 1;
            this.labelLastName.Text = "LastName";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(19, 22);
            this.labelFirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(71, 17);
            this.labelFirstName.TabIndex = 1;
            this.labelFirstName.Text = "FirstName";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(20, 95);
            this.labelEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(60, 17);
            this.labelEmail.TabIndex = 1;
            this.labelEmail.Text = "Email ID";
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Location = new System.Drawing.Point(19, 168);
            this.labelUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(73, 17);
            this.labelUserName.TabIndex = 1;
            this.labelUserName.Text = "UserName";
            // 
            // FormHello
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 262);
            this.Controls.Add(this.panelBorder);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormHello";
            this.Text = "Hello";
            this.Load += new System.EventHandler(this.FormHello_Load);
            this.panelBorder.ResumeLayout(false);
            this.panelBorder.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelBorder;
        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.ComboBox comboBoxUserName;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelDob;
        private System.Windows.Forms.DateTimePicker dateTimePickerDob;
        private System.Windows.Forms.RadioButton radioButtonAdult;
        private System.Windows.Forms.Button buttonSubmit;
    }
}

