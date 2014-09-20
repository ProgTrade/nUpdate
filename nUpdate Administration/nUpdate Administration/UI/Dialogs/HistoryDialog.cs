﻿// Author: Dominic Beger (Trade/ProgTrade)
// License: Creative Commons Attribution NoDerivs (CC-ND)
// Created: 01-08-2014 12:11
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using nUpdate.Administration.Core.Application;
using nUpdate.Administration.Core.Application.History;
using nUpdate.Administration.Properties;
using nUpdate.Administration.UI.Controls;

namespace nUpdate.Administration.UI.Dialogs
{
    public partial class HistoryDialog : BaseDialog
    {
        private readonly Stack<ServerListItem> _logItemsStack = new Stack<ServerListItem>();

        public HistoryDialog()
        {
            InitializeComponent();
        }

        /// <summary>
        ///     Initializes the log.
        /// </summary>
        private void InitializeLog()
        {
            if (Project.Log == null) return;
            if (Project.Log.Count == 0) return;
            foreach (Log logEntry in Project.Log)
            {
                var item = new ServerListItem
                {
                    ItemText = String.Format("{0} - {1}", logEntry.PackageVersion, logEntry.EntryTime)
                };

                switch (logEntry.Entry)
                {
                    case LogEntry.Create:
                        item.HeaderText = "Created package";
                        item.ServerImage = Resources.Create;
                        break;
                    case LogEntry.Delete:
                        item.HeaderText = "Deleted package";
                        item.ServerImage = Resources.Remove;
                        break;
                    case LogEntry.Upload:
                        item.HeaderText = "Uploaded package";
                        item.ServerImage = Resources.Upload;
                        break;
                }
                _logItemsStack.Push(item);
            }

            foreach (ServerListItem item in _logItemsStack)
            {
                historyList.Items.Add(item);
            }
        }

        private void SetActivationState()
        {
            if (_logItemsStack.Count == 0)
            {
                noHistoryLabel.Visible = true;
                clearLogButton.Enabled = false;
                saveToFileButton.Enabled = false;
                orderComboBox.Enabled = false;
            }
            else
            {
                noHistoryLabel.Visible = false;
                clearLogButton.Enabled = true;
                saveToFileButton.Enabled = true;
                orderComboBox.Enabled = true;
            }
        }

        /// <summary>
        ///     Orders the listbox items ascending.
        /// </summary>
        private void OrderAscending()
        {
            var ascendingItems = new Stack<ServerListItem>();
            foreach (ServerListItem item in _logItemsStack)
            {
                ascendingItems.Push(item);
            }

            historyList.Items.Clear();
            foreach (ServerListItem orderedItem in ascendingItems)
            {
                historyList.Items.Add(orderedItem);
            }
        }

        /// <summary>
        ///     Orders the listbox items descending.
        /// </summary>
        private void OrderDescending()
        {
            historyList.Items.Clear();
            foreach (ServerListItem orderedItem in _logItemsStack)
            {
                historyList.Items.Add(orderedItem);
            }
        }

        private void HistoryDialog_Load(object sender, EventArgs e)
        {
            Text = String.Format(Text, Project.Name);
            orderComboBox.SelectedIndex = 0;
            InitializeLog();
            SetActivationState();
        }

        private void clearLog_Click(object sender, EventArgs e)
        {
            Project.Log.Clear();
            ApplicationInstance.SaveProject(Project.Path, Project);
            Close();
        }

        private void orderComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (orderComboBox.SelectedIndex)
            {
                case 0:
                    OrderDescending();
                    break;
                case 1:
                    OrderAscending();
                    break;
            }
        }

        private void saveToFileButton_Click(object sender, EventArgs e)
        {
            using (var sfd = new SaveFileDialog())
            {
                sfd.Filter = "Text files (*.txt)|*.txt";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    var logEntryList = new List<string>();
                    foreach (Log logEntry in Project.Log)
                    {
                        logEntryList.Add(String.Format("{0}-{1}-{2}", logEntry.PackageVersion, logEntry.Entry,
                            logEntry.EntryTime));
                    }
                    File.WriteAllLines(sfd.FileName, logEntryList);
                }
            }
        }
    }
}