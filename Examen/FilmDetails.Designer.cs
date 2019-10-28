namespace Examen
{
    partial class FilmDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FilmDetails));
            this.FilmTitle = new System.Windows.Forms.Label();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.FilmDescription = new System.Windows.Forms.Label();
            this.FilmRating = new System.Windows.Forms.Label();
            this.FilmLength = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // FilmTitle
            // 
            this.FilmTitle.AutoSize = true;
            this.FilmTitle.Location = new System.Drawing.Point(295, 52);
            this.FilmTitle.Name = "FilmTitle";
            this.FilmTitle.Size = new System.Drawing.Size(45, 13);
            this.FilmTitle.TabIndex = 0;
            this.FilmTitle.Text = "FilmTitle";
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Location = new System.Drawing.Point(62, 121);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(60, 13);
            this.DescriptionLabel.TabIndex = 1;
            this.DescriptionLabel.Text = "Description";
            this.DescriptionLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // FilmDescription
            // 
            this.FilmDescription.AutoSize = true;
            this.FilmDescription.Location = new System.Drawing.Point(65, 156);
            this.FilmDescription.Name = "FilmDescription";
            this.FilmDescription.Size = new System.Drawing.Size(78, 13);
            this.FilmDescription.TabIndex = 2;
            this.FilmDescription.Text = "FilmDescription";
            this.FilmDescription.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // FilmRating
            // 
            this.FilmRating.AutoSize = true;
            this.FilmRating.Location = new System.Drawing.Point(598, 418);
            this.FilmRating.Name = "FilmRating";
            this.FilmRating.Size = new System.Drawing.Size(56, 13);
            this.FilmRating.TabIndex = 3;
            this.FilmRating.Text = "FilmRating";
            // 
            // FilmLength
            // 
            this.FilmLength.AutoSize = true;
            this.FilmLength.Location = new System.Drawing.Point(598, 394);
            this.FilmLength.Name = "FilmLength";
            this.FilmLength.Size = new System.Drawing.Size(58, 13);
            this.FilmLength.TabIndex = 4;
            this.FilmLength.Text = "FilmLength";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(531, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(229, 266);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // FilmDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.FilmLength);
            this.Controls.Add(this.FilmRating);
            this.Controls.Add(this.FilmDescription);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.FilmTitle);
            this.Name = "FilmDetails";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.FilmDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FilmTitle;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.Label FilmDescription;
        private System.Windows.Forms.Label FilmRating;
        private System.Windows.Forms.Label FilmLength;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}