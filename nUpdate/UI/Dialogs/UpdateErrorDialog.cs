﻿using System;
using System.Drawing;
using System.Windows.Forms;
using nUpdate.Dialogs;

namespace nUpdate.UI.Dialogs
{
    public partial class UpdateErrorDialog : BaseForm
    {
        public Icon AppIcon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);

        public UpdateErrorDialog()
        {
            InitializeComponent();
        }

        /// <summary>
        ///     Sets the code that is shown in the dialog.
        /// </summary>
        public int ErrorCode { get; set; }

        /// <summary>
        ///     Sets the error that occured.
        /// </summary>
        public Exception Error { get; set; }

        /// <summary>
        ///     Sets the short message that is shown on top of the dialog.
        /// </summary>
        public string InfoMessage { get; set; }

        private void UpdateErrorDialog_Load(object sender, EventArgs e)
        {
            infoLabel.Text = InfoMessage;

            errorCodeLabel.Text = ErrorCode == 0 ? "Errorcode: -" : String.Format("Errorcode: {0}", ErrorCode);

            errorMessageTextBox.Text = Error.Message;

            iconPictureBox.Image = SystemIcons.Error.ToBitmap();
            iconPictureBox.BackgroundImageLayout = ImageLayout.Center;

            Icon = AppIcon;
            Text = Application.ProductName;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void showStackTraceCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            errorMessageTextBox.Text = showStackTraceCheckBox.Checked ? String.Format("{0}\n{1}", Error.Message, Error.StackTrace) : Error.Message;
        }
    }
}