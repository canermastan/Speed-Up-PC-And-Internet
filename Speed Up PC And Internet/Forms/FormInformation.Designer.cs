namespace Speed_Up_PC_And_Internet
{
    partial class FormInformation
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
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.linkLblGithubProfile = new System.Windows.Forms.LinkLabel();
            this.linkLblContactMe = new System.Windows.Forms.LinkLabel();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Github;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 152;
            this.iconPictureBox1.Location = new System.Drawing.Point(213, 123);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(152, 170);
            this.iconPictureBox1.TabIndex = 0;
            this.iconPictureBox1.TabStop = false;
            // 
            // linkLblGithubProfile
            // 
            this.linkLblGithubProfile.AutoSize = true;
            this.linkLblGithubProfile.LinkColor = System.Drawing.Color.Gainsboro;
            this.linkLblGithubProfile.Location = new System.Drawing.Point(254, 268);
            this.linkLblGithubProfile.Name = "linkLblGithubProfile";
            this.linkLblGithubProfile.Size = new System.Drawing.Size(65, 25);
            this.linkLblGithubProfile.TabIndex = 2;
            this.linkLblGithubProfile.TabStop = true;
            this.linkLblGithubProfile.Text = "Github";
            this.linkLblGithubProfile.VisitedLinkColor = System.Drawing.Color.Gainsboro;
            this.linkLblGithubProfile.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLblGithubProfile_LinkClicked);
            // 
            // linkLblContactMe
            // 
            this.linkLblContactMe.AutoSize = true;
            this.linkLblContactMe.LinkColor = System.Drawing.Color.Gainsboro;
            this.linkLblContactMe.Location = new System.Drawing.Point(482, 268);
            this.linkLblContactMe.Name = "linkLblContactMe";
            this.linkLblContactMe.Size = new System.Drawing.Size(102, 25);
            this.linkLblContactMe.TabIndex = 4;
            this.linkLblContactMe.TabStop = true;
            this.linkLblContactMe.Text = "Bana Ulaşın";
            this.linkLblContactMe.VisitedLinkColor = System.Drawing.Color.Gainsboro;
            this.linkLblContactMe.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLblContactMe_LinkClicked);
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.iconPictureBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Comment;
            this.iconPictureBox2.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox2.IconSize = 152;
            this.iconPictureBox2.Location = new System.Drawing.Point(456, 123);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(152, 170);
            this.iconPictureBox2.TabIndex = 3;
            this.iconPictureBox2.TabStop = false;
            // 
            // FormInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(858, 460);
            this.Controls.Add(this.linkLblContactMe);
            this.Controls.Add(this.iconPictureBox2);
            this.Controls.Add(this.linkLblGithubProfile);
            this.Controls.Add(this.iconPictureBox1);
            this.Name = "FormInformation";
            this.Text = "FormInformation";
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private LinkLabel linkLblGithubProfile;
        private LinkLabel linkLblContactMe;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
    }
}