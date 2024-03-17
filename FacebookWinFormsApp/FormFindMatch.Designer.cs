namespace BasicFacebookFeatures
{
    partial class FormFindMatch
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label aboutLabel;
            System.Windows.Forms.Label birthdayLabel;
            System.Windows.Forms.Label emailLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFindMatch));
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.labelAbout = new System.Windows.Forms.Label();
            this.listBoxMatchFriendsNames = new System.Windows.Forms.ListBox();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelFindMatchResults = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureNormalURLRoundPictureBox = new BasicFacebookFeatures.RoundPictureBox();
            this.birthdayTextBox = new System.Windows.Forms.TextBox();
            this.aboutTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            aboutLabel = new System.Windows.Forms.Label();
            birthdayLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureNormalURLRoundPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // aboutLabel
            // 
            aboutLabel.AutoSize = true;
            aboutLabel.Location = new System.Drawing.Point(12, 175);
            aboutLabel.Name = "aboutLabel";
            aboutLabel.Size = new System.Drawing.Size(45, 16);
            aboutLabel.TabIndex = 20;
            aboutLabel.Text = "About:";
            // 
            // birthdayLabel
            // 
            birthdayLabel.AutoSize = true;
            birthdayLabel.Location = new System.Drawing.Point(12, 217);
            birthdayLabel.Name = "birthdayLabel";
            birthdayLabel.Size = new System.Drawing.Size(59, 16);
            birthdayLabel.TabIndex = 22;
            birthdayLabel.Text = "Birthday:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(13, 245);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(44, 16);
            emailLabel.TabIndex = 24;
            emailLabel.Text = "Email:";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(122, 298);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(8, 4);
            this.checkedListBox1.TabIndex = 16;
            // 
            // labelAbout
            // 
            this.labelAbout.AutoSize = true;
            this.labelAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelAbout.Location = new System.Drawing.Point(62, 175);
            this.labelAbout.Name = "labelAbout";
            this.labelAbout.Size = new System.Drawing.Size(62, 22);
            this.labelAbout.TabIndex = 14;
            this.labelAbout.Text = "About:";
            // 
            // listBoxMatchFriendsNames
            // 
            this.listBoxMatchFriendsNames.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.listBoxMatchFriendsNames.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.listBoxMatchFriendsNames.FormattingEnabled = true;
            this.listBoxMatchFriendsNames.ItemHeight = 22;
            this.listBoxMatchFriendsNames.Location = new System.Drawing.Point(66, 321);
            this.listBoxMatchFriendsNames.Name = "listBoxMatchFriendsNames";
            this.listBoxMatchFriendsNames.Size = new System.Drawing.Size(353, 312);
            this.listBoxMatchFriendsNames.TabIndex = 12;
            this.listBoxMatchFriendsNames.SelectedIndexChanged += new System.EventHandler(this.listBoxCollectionItemsNames_SelectedIndexChanged);
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.User);
            // 
            // labelFindMatchResults
            // 
            this.labelFindMatchResults.AutoSize = true;
            this.labelFindMatchResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelFindMatchResults.Location = new System.Drawing.Point(117, 9);
            this.labelFindMatchResults.Name = "labelFindMatchResults";
            this.labelFindMatchResults.Size = new System.Drawing.Size(235, 29);
            this.labelFindMatchResults.TabIndex = 19;
            this.labelFindMatchResults.Text = "Find Match Results";
            // 
            // panel1
            // 
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.pictureNormalURLRoundPictureBox);
            this.panel1.Controls.Add(aboutLabel);
            this.panel1.Controls.Add(this.birthdayTextBox);
            this.panel1.Controls.Add(this.aboutTextBox);
            this.panel1.Controls.Add(this.emailTextBox);
            this.panel1.Controls.Add(birthdayLabel);
            this.panel1.Controls.Add(emailLabel);
            this.panel1.Location = new System.Drawing.Point(53, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(383, 274);
            this.panel1.TabIndex = 21;
            // 
            // pictureNormalURLRoundPictureBox
            // 
            this.pictureNormalURLRoundPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.userBindingSource, "PictureNormalURL", true));
            this.pictureNormalURLRoundPictureBox.Location = new System.Drawing.Point(126, 12);
            this.pictureNormalURLRoundPictureBox.Name = "pictureNormalURLRoundPictureBox";
            this.pictureNormalURLRoundPictureBox.Size = new System.Drawing.Size(128, 114);
            this.pictureNormalURLRoundPictureBox.TabIndex = 28;
            this.pictureNormalURLRoundPictureBox.TabStop = false;
            // 
            // birthdayTextBox
            // 
            this.birthdayTextBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.birthdayTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Birthday", true));
            this.birthdayTextBox.Location = new System.Drawing.Point(78, 214);
            this.birthdayTextBox.Name = "birthdayTextBox";
            this.birthdayTextBox.ReadOnly = true;
            this.birthdayTextBox.Size = new System.Drawing.Size(288, 22);
            this.birthdayTextBox.TabIndex = 23;
            // 
            // aboutTextBox
            // 
            this.aboutTextBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.aboutTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "About", true));
            this.aboutTextBox.Location = new System.Drawing.Point(78, 161);
            this.aboutTextBox.Multiline = true;
            this.aboutTextBox.Name = "aboutTextBox";
            this.aboutTextBox.ReadOnly = true;
            this.aboutTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.aboutTextBox.Size = new System.Drawing.Size(288, 47);
            this.aboutTextBox.TabIndex = 21;
            // 
            // emailTextBox
            // 
            this.emailTextBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(78, 242);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.ReadOnly = true;
            this.emailTextBox.Size = new System.Drawing.Size(288, 22);
            this.emailTextBox.TabIndex = 25;
            // 
            // FormFindMatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 669);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelFindMatchResults);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.labelAbout);
            this.Controls.Add(this.listBoxMatchFriendsNames);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormFindMatch";
            this.Text = "Find Match";
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureNormalURLRoundPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label labelAbout;
        private System.Windows.Forms.ListBox listBoxMatchFriendsNames;
        private System.Windows.Forms.Label labelFindMatchResults;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox aboutTextBox;
        private System.Windows.Forms.TextBox birthdayTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private RoundPictureBox pictureNormalURLRoundPictureBox;
    }
}