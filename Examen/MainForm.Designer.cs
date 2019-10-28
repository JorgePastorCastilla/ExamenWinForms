namespace Examen
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.LoginTab = new System.Windows.Forms.TabPage();
            this.LogInButton = new System.Windows.Forms.Button();
            this.PaswordTextBox = new System.Windows.Forms.TextBox();
            this.UserTextBox = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.UserLabel = new System.Windows.Forms.Label();
            this.FilmsTab = new System.Windows.Forms.TabPage();
            this.FilmsListBox = new System.Windows.Forms.ListBox();
            this.WholeWordCheckBox = new System.Windows.Forms.CheckBox();
            this.FindButton = new System.Windows.Forms.Button();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.SearchLabel = new System.Windows.Forms.Label();
            this.StaffTab = new System.Windows.Forms.TabPage();
            this.UpdateEmailButton = new System.Windows.Forms.Button();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.staffImage = new System.Windows.Forms.PictureBox();
            this.HelloLabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.LoginTab.SuspendLayout();
            this.FilmsTab.SuspendLayout();
            this.StaffTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.staffImage)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControl1.Controls.Add(this.LoginTab);
            this.tabControl1.Controls.Add(this.FilmsTab);
            this.tabControl1.Controls.Add(this.StaffTab);
            this.tabControl1.Location = new System.Drawing.Point(12, 41);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(624, 489);
            this.tabControl1.TabIndex = 0;
            // 
            // LoginTab
            // 
            this.LoginTab.Controls.Add(this.LogInButton);
            this.LoginTab.Controls.Add(this.PaswordTextBox);
            this.LoginTab.Controls.Add(this.UserTextBox);
            this.LoginTab.Controls.Add(this.PasswordLabel);
            this.LoginTab.Controls.Add(this.UserLabel);
            this.LoginTab.Location = new System.Drawing.Point(23, 4);
            this.LoginTab.Name = "LoginTab";
            this.LoginTab.Padding = new System.Windows.Forms.Padding(3);
            this.LoginTab.Size = new System.Drawing.Size(597, 481);
            this.LoginTab.TabIndex = 0;
            this.LoginTab.Text = "Login";
            this.LoginTab.UseVisualStyleBackColor = true;
            // 
            // LogInButton
            // 
            this.LogInButton.Location = new System.Drawing.Point(223, 192);
            this.LogInButton.Name = "LogInButton";
            this.LogInButton.Size = new System.Drawing.Size(170, 38);
            this.LogInButton.TabIndex = 4;
            this.LogInButton.Text = "Log In";
            this.LogInButton.UseVisualStyleBackColor = true;
            this.LogInButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // PaswordTextBox
            // 
            this.PaswordTextBox.Location = new System.Drawing.Point(223, 148);
            this.PaswordTextBox.Name = "PaswordTextBox";
            this.PaswordTextBox.Size = new System.Drawing.Size(170, 20);
            this.PaswordTextBox.TabIndex = 3;
            this.PaswordTextBox.UseSystemPasswordChar = true;
            // 
            // UserTextBox
            // 
            this.UserTextBox.Location = new System.Drawing.Point(223, 109);
            this.UserTextBox.Name = "UserTextBox";
            this.UserTextBox.Size = new System.Drawing.Size(170, 20);
            this.UserTextBox.TabIndex = 2;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(173, 151);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(53, 13);
            this.PasswordLabel.TabIndex = 1;
            this.PasswordLabel.Text = "Password";
            // 
            // UserLabel
            // 
            this.UserLabel.AutoSize = true;
            this.UserLabel.Location = new System.Drawing.Point(188, 112);
            this.UserLabel.Name = "UserLabel";
            this.UserLabel.Size = new System.Drawing.Size(29, 13);
            this.UserLabel.TabIndex = 0;
            this.UserLabel.Text = "User";
            // 
            // FilmsTab
            // 
            this.FilmsTab.Controls.Add(this.FilmsListBox);
            this.FilmsTab.Controls.Add(this.WholeWordCheckBox);
            this.FilmsTab.Controls.Add(this.FindButton);
            this.FilmsTab.Controls.Add(this.SearchTextBox);
            this.FilmsTab.Controls.Add(this.SearchLabel);
            this.FilmsTab.Location = new System.Drawing.Point(23, 4);
            this.FilmsTab.Name = "FilmsTab";
            this.FilmsTab.Padding = new System.Windows.Forms.Padding(3);
            this.FilmsTab.Size = new System.Drawing.Size(597, 481);
            this.FilmsTab.TabIndex = 1;
            this.FilmsTab.Text = "Films";
            this.FilmsTab.UseVisualStyleBackColor = true;
            // 
            // FilmsListBox
            // 
            this.FilmsListBox.FormattingEnabled = true;
            this.FilmsListBox.Location = new System.Drawing.Point(86, 88);
            this.FilmsListBox.Name = "FilmsListBox";
            this.FilmsListBox.Size = new System.Drawing.Size(426, 355);
            this.FilmsListBox.TabIndex = 4;
            this.FilmsListBox.SelectedIndexChanged += new System.EventHandler(this.FilmsListBox_SelectedIndexChanged);
            this.FilmsListBox.DoubleClick += new System.EventHandler(this.FilmsListBox_DoubleClick_1);
            // 
            // WholeWordCheckBox
            // 
            this.WholeWordCheckBox.AutoSize = true;
            this.WholeWordCheckBox.Location = new System.Drawing.Point(400, 60);
            this.WholeWordCheckBox.Name = "WholeWordCheckBox";
            this.WholeWordCheckBox.Size = new System.Drawing.Size(113, 17);
            this.WholeWordCheckBox.TabIndex = 3;
            this.WholeWordCheckBox.Text = "Match whole word";
            this.WholeWordCheckBox.UseVisualStyleBackColor = true;
            // 
            // FindButton
            // 
            this.FindButton.Location = new System.Drawing.Point(438, 31);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(75, 23);
            this.FindButton.TabIndex = 2;
            this.FindButton.Text = "Find";
            this.FindButton.UseVisualStyleBackColor = true;
            this.FindButton.Click += new System.EventHandler(this.FindButton_Click);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(145, 31);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(266, 20);
            this.SearchTextBox.TabIndex = 1;
            // 
            // SearchLabel
            // 
            this.SearchLabel.AutoSize = true;
            this.SearchLabel.Location = new System.Drawing.Point(83, 34);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(44, 13);
            this.SearchLabel.TabIndex = 0;
            this.SearchLabel.Text = "Search:";
            // 
            // StaffTab
            // 
            this.StaffTab.Controls.Add(this.staffImage);
            this.StaffTab.Controls.Add(this.UpdateEmailButton);
            this.StaffTab.Controls.Add(this.EmailTextBox);
            this.StaffTab.Controls.Add(this.EmailLabel);
            this.StaffTab.Location = new System.Drawing.Point(23, 4);
            this.StaffTab.Name = "StaffTab";
            this.StaffTab.Size = new System.Drawing.Size(597, 481);
            this.StaffTab.TabIndex = 2;
            this.StaffTab.Text = "Staff";
            this.StaffTab.UseVisualStyleBackColor = true;
            // 
            // UpdateEmailButton
            // 
            this.UpdateEmailButton.Location = new System.Drawing.Point(342, 153);
            this.UpdateEmailButton.Name = "UpdateEmailButton";
            this.UpdateEmailButton.Size = new System.Drawing.Size(75, 23);
            this.UpdateEmailButton.TabIndex = 3;
            this.UpdateEmailButton.Text = "Update";
            this.UpdateEmailButton.UseVisualStyleBackColor = true;
            this.UpdateEmailButton.Click += new System.EventHandler(this.UpdateEmailButton_Click);
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(199, 113);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(219, 20);
            this.EmailTextBox.TabIndex = 2;
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(151, 116);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(32, 13);
            this.EmailLabel.TabIndex = 1;
            this.EmailLabel.Text = "Email";
            // 
            // staffImage
            // 
            this.staffImage.Image = ((System.Drawing.Image)(resources.GetObject("staffImage.Image")));
            this.staffImage.Location = new System.Drawing.Point(3, 0);
            this.staffImage.Name = "staffImage";
            this.staffImage.Size = new System.Drawing.Size(591, 478);
            this.staffImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.staffImage.TabIndex = 4;
            this.staffImage.TabStop = false;
            // 
            // HelloLabel
            // 
            this.HelloLabel.AutoSize = true;
            this.HelloLabel.Location = new System.Drawing.Point(270, 13);
            this.HelloLabel.Name = "HelloLabel";
            this.HelloLabel.Size = new System.Drawing.Size(32, 13);
            this.HelloLabel.TabIndex = 1;
            this.HelloLabel.Text = "hello ";
            this.HelloLabel.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 542);
            this.Controls.Add(this.HelloLabel);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.LoginTab.ResumeLayout(false);
            this.LoginTab.PerformLayout();
            this.FilmsTab.ResumeLayout(false);
            this.FilmsTab.PerformLayout();
            this.StaffTab.ResumeLayout(false);
            this.StaffTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.staffImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage LoginTab;
        private System.Windows.Forms.TabPage FilmsTab;
        private System.Windows.Forms.ListBox FilmsListBox;
        private System.Windows.Forms.CheckBox WholeWordCheckBox;
        private System.Windows.Forms.Button FindButton;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Label SearchLabel;
        private System.Windows.Forms.TabPage StaffTab;
        private System.Windows.Forms.Button LogInButton;
        private System.Windows.Forms.TextBox PaswordTextBox;
        private System.Windows.Forms.TextBox UserTextBox;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label UserLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Button UpdateEmailButton;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.PictureBox staffImage;
        private System.Windows.Forms.Label HelloLabel;
    }
}

