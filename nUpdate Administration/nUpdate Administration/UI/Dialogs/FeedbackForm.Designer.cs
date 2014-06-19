﻿namespace nUpdate.Administration.UI.Dialogs
{
    partial class FeedbackForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FeedbackForm));
            this.sendButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.privacyTermsLinkLabel = new System.Windows.Forms.LinkLabel();
            this.nameTextBox = new nUpdate.Administration.WatermarkTextBox();
            this.emailTextBox = new nUpdate.Administration.WatermarkTextBox();
            this.contentTextBox = new nUpdate.Administration.WatermarkTextBox();
            this.cpnl = new nUpdate.Administration.UI.Controls.ControlPanel();
            this.headerLabel = new System.Windows.Forms.Label();
            this.cpnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // sendButton
            // 
            this.sendButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.sendButton.Location = new System.Drawing.Point(355, 7);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(75, 23);
            this.sendButton.TabIndex = 24;
            this.sendButton.Text = "Send";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cancelButton.Location = new System.Drawing.Point(274, 7);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 25;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // privacyTermsLinkLabel
            // 
            this.privacyTermsLinkLabel.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.privacyTermsLinkLabel.AutoSize = true;
            this.privacyTermsLinkLabel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.privacyTermsLinkLabel.Location = new System.Drawing.Point(286, 201);
            this.privacyTermsLinkLabel.Name = "privacyTermsLinkLabel";
            this.privacyTermsLinkLabel.Size = new System.Drawing.Size(144, 13);
            this.privacyTermsLinkLabel.TabIndex = 19;
            this.privacyTermsLinkLabel.TabStop = true;
            this.privacyTermsLinkLabel.Text = "How will my data be used?";
            this.privacyTermsLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.privacyTermsLinkLabel_LinkClicked);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Cue = "Name";
            this.nameTextBox.Location = new System.Drawing.Point(230, 43);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(198, 22);
            this.nameTextBox.TabIndex = 18;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Cue = "Your E-mail adress";
            this.emailTextBox.Location = new System.Drawing.Point(12, 43);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(212, 22);
            this.emailTextBox.TabIndex = 17;
            // 
            // contentTextBox
            // 
            this.contentTextBox.AcceptsReturn = true;
            this.contentTextBox.AcceptsTab = true;
            this.contentTextBox.Cue = "Your message...";
            this.contentTextBox.Location = new System.Drawing.Point(12, 74);
            this.contentTextBox.Multiline = true;
            this.contentTextBox.Name = "contentTextBox";
            this.contentTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.contentTextBox.Size = new System.Drawing.Size(416, 114);
            this.contentTextBox.TabIndex = 16;
            // 
            // cpnl
            // 
            this.cpnl.BackColor = System.Drawing.SystemColors.Control;
            this.cpnl.Controls.Add(this.cancelButton);
            this.cpnl.Controls.Add(this.sendButton);
            this.cpnl.Location = new System.Drawing.Point(0, 228);
            this.cpnl.Name = "cpnl";
            this.cpnl.Size = new System.Drawing.Size(442, 38);
            this.cpnl.TabIndex = 9;
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.headerLabel.Location = new System.Drawing.Point(8, 9);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(72, 20);
            this.headerLabel.TabIndex = 20;
            this.headerLabel.Text = "Feedback";
            // 
            // FeedbackForm
            // 
            this.AcceptButton = this.sendButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(442, 266);
            this.Controls.Add(this.headerLabel);
            this.Controls.Add(this.privacyTermsLinkLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.contentTextBox);
            this.Controls.Add(this.cpnl);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FeedbackForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Feedback - nUpdate Administration 1.1.0.0";
            this.Load += new System.EventHandler(this.FeedbackForm_Load);
            this.cpnl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.ControlPanel cpnl;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button sendButton;
        private WatermarkTextBox contentTextBox;
        private WatermarkTextBox emailTextBox;
        private WatermarkTextBox nameTextBox;
        private System.Windows.Forms.LinkLabel privacyTermsLinkLabel;
        private System.Windows.Forms.Label headerLabel;
    }
}