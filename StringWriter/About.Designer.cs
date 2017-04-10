namespace StringWriter
{
    partial class About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            this.TitleLabel = new System.Windows.Forms.Label();
            this.creditsLabel = new System.Windows.Forms.Label();
            this.creatorLabel = new System.Windows.Forms.Label();
            this.projectLabel = new System.Windows.Forms.Label();
            this.LinksourceLabel = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.TitleLabel.Location = new System.Drawing.Point(27, 19);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(298, 21);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "String Writer-r3 (Highlighting Location)";
            // 
            // creditsLabel
            // 
            this.creditsLabel.AutoSize = true;
            this.creditsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.creditsLabel.Location = new System.Drawing.Point(34, 78);
            this.creditsLabel.Name = "creditsLabel";
            this.creditsLabel.Size = new System.Drawing.Size(276, 13);
            this.creditsLabel.TabIndex = 0;
            this.creditsLabel.Text = "Credits to Chadderz, Splatonka, Lean, and NWPlayer123";
            // 
            // creatorLabel
            // 
            this.creatorLabel.AutoSize = true;
            this.creatorLabel.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.creatorLabel.Location = new System.Drawing.Point(121, 42);
            this.creatorLabel.Name = "creatorLabel";
            this.creatorLabel.Size = new System.Drawing.Size(95, 21);
            this.creatorLabel.TabIndex = 0;
            this.creatorLabel.Text = "by Yahya14";
            // 
            // projectLabel
            // 
            this.projectLabel.AutoSize = true;
            this.projectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.projectLabel.Location = new System.Drawing.Point(15, 107);
            this.projectLabel.Name = "projectLabel";
            this.projectLabel.Size = new System.Drawing.Size(331, 117);
            this.projectLabel.TabIndex = 0;
            this.projectLabel.Text = resources.GetString("projectLabel.Text");
            // 
            // LinksourceLabel
            // 
            this.LinksourceLabel.AutoSize = true;
            this.LinksourceLabel.Location = new System.Drawing.Point(15, 216);
            this.LinksourceLabel.Name = "LinksourceLabel";
            this.LinksourceLabel.Size = new System.Drawing.Size(238, 13);
            this.LinksourceLabel.TabIndex = 1;
            this.LinksourceLabel.TabStop = true;
            this.LinksourceLabel.Text = "https://github.com/yahya14/StringWriter_Gecko";
            this.LinksourceLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinksourceLabel_LinkClicked);
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(355, 252);
            this.Controls.Add(this.LinksourceLabel);
            this.Controls.Add(this.projectLabel);
            this.Controls.Add(this.creditsLabel);
            this.Controls.Add(this.creatorLabel);
            this.Controls.Add(this.TitleLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "About";
            this.Text = "About";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label creditsLabel;
        private System.Windows.Forms.Label creatorLabel;
        private System.Windows.Forms.Label projectLabel;
        private System.Windows.Forms.LinkLabel LinksourceLabel;
    }
}