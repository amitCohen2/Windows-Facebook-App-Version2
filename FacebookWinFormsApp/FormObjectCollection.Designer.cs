﻿namespace BasicFacebookFeatures
{
    partial class FormObjectCollection<T>
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
            this.listBoxCollectionItemsNames = new System.Windows.Forms.ListBox();
            this.textBoxSearchByName = new System.Windows.Forms.TextBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.buttonShowPictures = new System.Windows.Forms.Button();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.roundPictureBox = new BasicFacebookFeatures.RoundPictureBox();
            this.labelName = new System.Windows.Forms.Label();
            this.DescriptionCheckBox = new System.Windows.Forms.CheckBox();
            this.imageCheckBox = new System.Windows.Forms.CheckBox();
            this.searchButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.roundPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxCollectionItemsNames
            // 
            this.listBoxCollectionItemsNames.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.listBoxCollectionItemsNames.FormattingEnabled = true;
            this.listBoxCollectionItemsNames.ItemHeight = 16;
            this.listBoxCollectionItemsNames.Location = new System.Drawing.Point(84, 371);
            this.listBoxCollectionItemsNames.Name = "listBoxCollectionItemsNames";
            this.listBoxCollectionItemsNames.Size = new System.Drawing.Size(400, 292);
            this.listBoxCollectionItemsNames.TabIndex = 1;
            this.listBoxCollectionItemsNames.SelectedIndexChanged += new System.EventHandler(this.listBoxCollectionItemsNames_SelectedIndexChanged);
            // 
            // textBoxSearchByName
            // 
            this.textBoxSearchByName.AccessibleDescription = "";
            this.textBoxSearchByName.AccessibleName = "";
            this.textBoxSearchByName.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textBoxSearchByName.Location = new System.Drawing.Point(84, 307);
            this.textBoxSearchByName.Name = "textBoxSearchByName";
            this.textBoxSearchByName.Size = new System.Drawing.Size(400, 22);
            this.textBoxSearchByName.TabIndex = 4;
            this.textBoxSearchByName.Text = "search by name";
            this.textBoxSearchByName.Enter += new System.EventHandler(this.textBoxSearchByName_Enter);
            this.textBoxSearchByName.Leave += new System.EventHandler(this.textBoxSearchByName_Leave);
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(81, 213);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(78, 16);
            this.labelDescription.TabIndex = 5;
            this.labelDescription.Text = "Description:";
            // 
            // buttonShowPictures
            // 
            this.buttonShowPictures.BackColor = System.Drawing.Color.Lavender;
            this.buttonShowPictures.Location = new System.Drawing.Point(182, 186);
            this.buttonShowPictures.Name = "buttonShowPictures";
            this.buttonShowPictures.Size = new System.Drawing.Size(191, 31);
            this.buttonShowPictures.TabIndex = 6;
            this.buttonShowPictures.Text = "Show all pictures in album";
            this.buttonShowPictures.UseVisualStyleBackColor = false;
            this.buttonShowPictures.Click += new System.EventHandler(this.buttonShowPictures_Click);
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.AccessibleDescription = "";
            this.textBoxDescription.AccessibleName = "";
            this.textBoxDescription.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textBoxDescription.Location = new System.Drawing.Point(84, 232);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxDescription.Size = new System.Drawing.Size(400, 69);
            this.textBoxDescription.TabIndex = 10;
            // 
            // roundPictureBox
            // 
            this.roundPictureBox.Location = new System.Drawing.Point(212, 12);
            this.roundPictureBox.Name = "roundPictureBox";
            this.roundPictureBox.Size = new System.Drawing.Size(125, 125);
            this.roundPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.roundPictureBox.TabIndex = 11;
            this.roundPictureBox.TabStop = false;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelName.Location = new System.Drawing.Point(79, 154);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(0, 22);
            this.labelName.TabIndex = 12;
            // 
            // DescriptionCheckBox
            // 
            this.DescriptionCheckBox.AutoSize = true;
            this.DescriptionCheckBox.Location = new System.Drawing.Point(211, 339);
            this.DescriptionCheckBox.Name = "DescriptionCheckBox";
            this.DescriptionCheckBox.Size = new System.Drawing.Size(145, 20);
            this.DescriptionCheckBox.TabIndex = 14;
            this.DescriptionCheckBox.Text = "Filter by description";
            this.DescriptionCheckBox.UseVisualStyleBackColor = true;
            // 
            // imageCheckBox
            // 
            this.imageCheckBox.AutoSize = true;
            this.imageCheckBox.Location = new System.Drawing.Point(84, 339);
            this.imageCheckBox.Name = "imageCheckBox";
            this.imageCheckBox.Size = new System.Drawing.Size(117, 20);
            this.imageCheckBox.TabIndex = 13;
            this.imageCheckBox.Text = "Filter by Image";
            this.imageCheckBox.UseVisualStyleBackColor = true;
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.Lavender;
            this.searchButton.Location = new System.Drawing.Point(362, 335);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(122, 26);
            this.searchButton.TabIndex = 15;
            this.searchButton.Text = "Search by Filters";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // FormObjectCollection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 691);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.DescriptionCheckBox);
            this.Controls.Add(this.imageCheckBox);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.roundPictureBox);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.buttonShowPictures);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.textBoxSearchByName);
            this.Controls.Add(this.listBoxCollectionItemsNames);
            this.Name = "FormObjectCollection";
            this.Text = "Form Collection Item";
            this.Load += new System.EventHandler(this.FormCollectionItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.roundPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxCollectionItemsNames;
        private System.Windows.Forms.TextBox textBoxSearchByName;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Button buttonShowPictures;
        private System.Windows.Forms.TextBox textBoxDescription;
        private RoundPictureBox roundPictureBox;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.CheckBox DescriptionCheckBox;
        private System.Windows.Forms.CheckBox imageCheckBox;
        private System.Windows.Forms.Button searchButton;
    }
}