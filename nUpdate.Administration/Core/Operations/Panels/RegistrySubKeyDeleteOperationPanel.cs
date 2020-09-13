﻿// RegistrySubKeyDeleteOperationPanel.cs, 10.06.2019
// Copyright (C) Dominic Beger 17.06.2019

using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using nUpdate.Actions;

namespace nUpdate.Administration.Core.Operations.Panels
{
    public partial class RegistrySubKeyDeleteOperationPanel : UserControl, IOperationPanel
    {
        public RegistrySubKeyDeleteOperationPanel()
        {
            InitializeComponent();
        }

        public BindingList<string> ItemList { get; set; } = new BindingList<string>();

        public string KeyPath
        {
            get => $"{mainKeyComboBox.GetItemText(mainKeyComboBox.SelectedItem)}\\{subKeyTextBox.Text}";
            set
            {
                var pathParts = value.Split('\\');
                mainKeyComboBox.SelectedValue = pathParts[0];
                subKeyTextBox.Text = string.Join("\\", pathParts.Skip(1));
            }
        }

        public bool IsValid => !string.IsNullOrEmpty(subKeyTextBox.Text) && ItemList.Any();

        public IUpdateAction Operation => new DeleteRegistrySubKeyAction();

        private void addButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(keyNameTextBox.Text))
                return;
            ItemList.Add(keyNameTextBox.Text);
            keyNameTextBox.Clear();
        }

        private void InputChanged(object sender, EventArgs e)
        {
            var textBox = (TextBox) sender;
            if (!textBox.Text.Contains("/"))
                return;
            textBox.Text = textBox.Text.Replace('/', '\\');
            textBox.SelectionStart = textBox.Text.Length;
            textBox.SelectionLength = 0;
        }

        private void keyNameTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                addButton.PerformClick();
        }

        private void RegistryEntryDeleteOperationPanel_Load(object sender, EventArgs e)
        {
            subKeysToDeleteListBox.DataSource = ItemList;
            mainKeyComboBox.SelectedIndex = 0;
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            ItemList.RemoveAt(subKeysToDeleteListBox.SelectedIndex);
        }
    }
}