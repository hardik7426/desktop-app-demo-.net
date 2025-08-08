namespace desktop_app_demo
{
    partial class Form2
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
            this.Name = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.Branch = new System.Windows.Forms.Label();
            this.City = new System.Windows.Forms.Label();
            this.nametxt = new System.Windows.Forms.TextBox();
            this.passwordtxt = new System.Windows.Forms.TextBox();
            this.citytxt = new System.Windows.Forms.ListBox();
            this.Gender = new System.Windows.Forms.Label();
            this.Male = new System.Windows.Forms.RadioButton();
            this.Female = new System.Windows.Forms.RadioButton();
            this.branchtxt = new System.Windows.Forms.ComboBox();
            this.Submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name.Location = new System.Drawing.Point(96, 83);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(44, 16);
            this.Name.TabIndex = 0;
            this.Name.Text = "Name";
            this.Name.Click += new System.EventHandler(this.label1_Click);
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Password.Location = new System.Drawing.Point(96, 115);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(67, 16);
            this.Password.TabIndex = 1;
            this.Password.Text = "Password";
            // 
            // Branch
            // 
            this.Branch.AutoSize = true;
            this.Branch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Branch.Location = new System.Drawing.Point(96, 146);
            this.Branch.Name = "Branch";
            this.Branch.Size = new System.Drawing.Size(49, 16);
            this.Branch.TabIndex = 2;
            this.Branch.Text = "Branch";
            this.Branch.Click += new System.EventHandler(this.label2_Click);
            // 
            // City
            // 
            this.City.AutoSize = true;
            this.City.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.City.Location = new System.Drawing.Point(96, 179);
            this.City.Name = "City";
            this.City.Size = new System.Drawing.Size(29, 16);
            this.City.TabIndex = 3;
            this.City.Text = "City";
            // 
            // nametxt
            // 
            this.nametxt.Location = new System.Drawing.Point(181, 83);
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(162, 22);
            this.nametxt.TabIndex = 4;
            this.nametxt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // passwordtxt
            // 
            this.passwordtxt.Location = new System.Drawing.Point(181, 112);
            this.passwordtxt.Name = "passwordtxt";
            this.passwordtxt.PasswordChar = '*';
            this.passwordtxt.Size = new System.Drawing.Size(100, 22);
            this.passwordtxt.TabIndex = 5;
            this.passwordtxt.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // citytxt
            // 
            this.citytxt.FormattingEnabled = true;
            this.citytxt.ItemHeight = 16;
            this.citytxt.Items.AddRange(new object[] {
            "Rajkot",
            "Morbi",
            "Surat",
            "Amreli"});
            this.citytxt.Location = new System.Drawing.Point(182, 170);
            this.citytxt.Name = "citytxt";
            this.citytxt.Size = new System.Drawing.Size(120, 52);
            this.citytxt.TabIndex = 7;
            // 
            // Gender
            // 
            this.Gender.AutoSize = true;
            this.Gender.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Gender.Location = new System.Drawing.Point(96, 239);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(52, 16);
            this.Gender.TabIndex = 8;
            this.Gender.Text = "Gender";
            // 
            // Male
            // 
            this.Male.AutoSize = true;
            this.Male.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Male.Location = new System.Drawing.Point(181, 237);
            this.Male.Name = "Male";
            this.Male.Size = new System.Drawing.Size(58, 20);
            this.Male.TabIndex = 9;
            this.Male.TabStop = true;
            this.Male.Text = "Male";
            this.Male.UseVisualStyleBackColor = true;
            this.Male.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // Female
            // 
            this.Female.AutoSize = true;
            this.Female.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Female.Location = new System.Drawing.Point(245, 239);
            this.Female.Name = "Female";
            this.Female.Size = new System.Drawing.Size(74, 20);
            this.Female.TabIndex = 10;
            this.Female.TabStop = true;
            this.Female.Text = "Female";
            this.Female.UseVisualStyleBackColor = true;
            this.Female.CheckedChanged += new System.EventHandler(this.Female_CheckedChanged);
            // 
            // branchtxt
            // 
            this.branchtxt.FormattingEnabled = true;
            this.branchtxt.Items.AddRange(new object[] {
            "CE",
            "IT"});
            this.branchtxt.Location = new System.Drawing.Point(181, 140);
            this.branchtxt.Name = "branchtxt";
            this.branchtxt.Size = new System.Drawing.Size(121, 24);
            this.branchtxt.TabIndex = 11;
            this.branchtxt.SelectedIndexChanged += new System.EventHandler(this.branchtxt_SelectedIndexChanged);
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(182, 277);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(75, 23);
            this.Submit.TabIndex = 12;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.branchtxt);
            this.Controls.Add(this.Female);
            this.Controls.Add(this.Male);
            this.Controls.Add(this.Gender);
            this.Controls.Add(this.citytxt);
            this.Controls.Add(this.passwordtxt);
            this.Controls.Add(this.nametxt);
            this.Controls.Add(this.City);
            this.Controls.Add(this.Branch);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Name);
            //this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Label Branch;
        private System.Windows.Forms.Label City;
        private System.Windows.Forms.TextBox nametxt;
        private System.Windows.Forms.TextBox passwordtxt;
        private System.Windows.Forms.ListBox citytxt;
        private System.Windows.Forms.Label Gender;
        private System.Windows.Forms.RadioButton Male;
        private System.Windows.Forms.RadioButton Female;
        private System.Windows.Forms.ComboBox branchtxt;
        private System.Windows.Forms.Button Submit;
    }
}