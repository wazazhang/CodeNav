﻿using System;
using System.Windows.Forms;
using CodeNav.Properties;

namespace CodeNav
{
    public partial class FilterToolWindow : Form
    {
        public FilterToolWindow()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void uncheckAllButton_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1.Items)
            {
                item.Checked = false;
            }
        }

        private void checkAllButton_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1.Items)
            {
                item.Checked = true;
            }
        }

        private void FilterToolWindow_Load(object sender, EventArgs e)
        {
            listView1.Items[0].Checked = Settings.Default.ShowConstants;
            listView1.Items[1].Checked = Settings.Default.ShowConstructors;
            listView1.Items[2].Checked = Settings.Default.ShowEnumItems;
            listView1.Items[3].Checked = Settings.Default.ShowEvents;
            listView1.Items[4].Checked = Settings.Default.ShowMethods;
            listView1.Items[5].Checked = Settings.Default.ShowProperties;
            listView1.Items[6].Checked = Settings.Default.ShowVariables;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            Settings.Default.ShowConstants = listView1.Items[0].Checked;
            Settings.Default.ShowConstructors = listView1.Items[1].Checked;
            Settings.Default.ShowEnumItems = listView1.Items[2].Checked;
            Settings.Default.ShowEvents = listView1.Items[3].Checked;
            Settings.Default.ShowMethods = listView1.Items[4].Checked;
            Settings.Default.ShowProperties = listView1.Items[5].Checked;
            Settings.Default.ShowVariables = listView1.Items[6].Checked;

            Close();
        }
    }
}
