﻿// Author: Dominic Beger (Trade/ProgTrade)
// License: Creative Commons Attribution NoDerivs (CC-ND)
// Created: 01-08-2014 12:11
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace nUpdate.Administration.UI.Dialogs
{
    public partial class InfoDialog : BaseDialog
    {
        public InfoDialog()
        {
            InitializeComponent();
        }

        private void InfoForm_Load(object sender, EventArgs e)
        {
            copyrightLabel.Text += DateTime.Now.Year.ToString();
        }

        private void iconPackLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://p.yusukekamiyamane.com/");
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void InfoForm_Shown(object sender, EventArgs e)
        {
            closeButton.Focus();
        }

        private void timSchieweLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/timmi31061");
        }


        private void artentusLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/Artentus");
        }

        private void ll_github_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/ProgTrade/nUpdate");
        }

        private void websiteLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://www.nupdate.net");
        }

        private void donatePictureBox_Click(object sender, EventArgs e)
        {
            string url = "";

            const string business = "Ch.beger@web.de";
            const string description = "Will%20be%20used%20for%20code%20signing%20certificates%20for%20nUpdate";
            const string country = "DE";
            const string currency = "EUR";

            url +=
                String.Format(
                    "https://www.paypal.com/cgi-bin/webscr?cmd=_donations&business={0}&lc={1}&item_name={2}&currency_code={3}&bn=PP%2dDonationsBF",
                    business, country, description, currency);

            Process.Start(url);
        }

        private void dotNetZipLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://dotnetzip.codeplex.com/");
        }

        private void jsonNetLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://james.newtonking.com/json");
        }

        private void fastColoredTextBoxLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://www.codeproject.com/Articles/161871/Fast-Colored-TextBox-for-syntax-highlighting");
        }

        private void osIconLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://osicon.codeplex.com/");
        }

        private void starksoftFtpLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://biko.codeplex.com/");
        }

        private void starksoftProxyLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://biko.codeplex.com/");
        }
    }
}