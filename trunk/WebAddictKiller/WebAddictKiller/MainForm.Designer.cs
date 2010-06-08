namespace WebAddictKiller
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
            this.buttonApply = new System.Windows.Forms.Button();
            this.buttonRestore = new System.Windows.Forms.Button();
            this.websiteCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.buttonSelectAll = new System.Windows.Forms.Button();
            this.buttonAddNewWebsite = new System.Windows.Forms.Button();
            this.buttonDeleteFromList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonApply
            // 
            this.buttonApply.Font = new System.Drawing.Font("SimSun", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonApply.Location = new System.Drawing.Point(249, 151);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(437, 70);
            this.buttonApply.TabIndex = 0;
            this.buttonApply.Text = "KILL MY ADDICTION NOW AND FOREVER!";
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // buttonRestore
            // 
            this.buttonRestore.Font = new System.Drawing.Font("SimSun", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonRestore.Location = new System.Drawing.Point(249, 236);
            this.buttonRestore.Name = "buttonRestore";
            this.buttonRestore.Size = new System.Drawing.Size(437, 45);
            this.buttonRestore.TabIndex = 1;
            this.buttonRestore.Text = "FUCK ME! I AM PATHETIC LOSER!";
            this.buttonRestore.UseVisualStyleBackColor = true;
            this.buttonRestore.Click += new System.EventHandler(this.buttonRestore_Click);
            // 
            // websiteCheckedListBox
            // 
            this.websiteCheckedListBox.FormattingEnabled = true;
            this.websiteCheckedListBox.Location = new System.Drawing.Point(250, 12);
            this.websiteCheckedListBox.Name = "websiteCheckedListBox";
            this.websiteCheckedListBox.Size = new System.Drawing.Size(289, 116);
            this.websiteCheckedListBox.TabIndex = 3;
            // 
            // buttonSelectAll
            // 
            this.buttonSelectAll.Location = new System.Drawing.Point(544, 105);
            this.buttonSelectAll.Name = "buttonSelectAll";
            this.buttonSelectAll.Size = new System.Drawing.Size(142, 23);
            this.buttonSelectAll.TabIndex = 4;
            this.buttonSelectAll.Text = "Select all";
            this.buttonSelectAll.UseVisualStyleBackColor = true;
            this.buttonSelectAll.Click += new System.EventHandler(this.buttonSelectAll_Click);
            // 
            // buttonAddNewWebsite
            // 
            this.buttonAddNewWebsite.Location = new System.Drawing.Point(544, 12);
            this.buttonAddNewWebsite.Name = "buttonAddNewWebsite";
            this.buttonAddNewWebsite.Size = new System.Drawing.Size(142, 23);
            this.buttonAddNewWebsite.TabIndex = 6;
            this.buttonAddNewWebsite.Text = "Add new website";
            this.buttonAddNewWebsite.UseVisualStyleBackColor = true;
            this.buttonAddNewWebsite.Click += new System.EventHandler(this.buttonAddNewWebsite_Click);
            // 
            // buttonDeleteFromList
            // 
            this.buttonDeleteFromList.Location = new System.Drawing.Point(544, 59);
            this.buttonDeleteFromList.Name = "buttonDeleteFromList";
            this.buttonDeleteFromList.Size = new System.Drawing.Size(141, 23);
            this.buttonDeleteFromList.TabIndex = 7;
            this.buttonDeleteFromList.Text = "Delete from list";
            this.buttonDeleteFromList.UseVisualStyleBackColor = true;
            this.buttonDeleteFromList.Click += new System.EventHandler(this.buttonDeleteFromList_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WebAddictKiller.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(698, 293);
            this.Controls.Add(this.buttonDeleteFromList);
            this.Controls.Add(this.buttonAddNewWebsite);
            this.Controls.Add(this.buttonSelectAll);
            this.Controls.Add(this.websiteCheckedListBox);
            this.Controls.Add(this.buttonRestore);
            this.Controls.Add(this.buttonApply);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "Web Addict Killer";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.Button buttonRestore;
        private System.Windows.Forms.CheckedListBox websiteCheckedListBox;
        private System.Windows.Forms.Button buttonSelectAll;
        private System.Windows.Forms.Button buttonAddNewWebsite;
        private System.Windows.Forms.Button buttonDeleteFromList;
    }
}

