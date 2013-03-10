using Interfaces;
using System;
using System.IO;
using System.Windows.Forms;

namespace FilesystemUploader.Forms
{
    public partial class SettingsForm : Form
    {
        private readonly ISettingsStorage settingsStorage;

        public SettingsForm(ISettingsStorage settingsStorage)
        {
            InitializeComponent();
            this.settingsStorage = settingsStorage;
            String savedPath = settingsStorage.GetValue(SettingsKeys.OutputDirectoryKey);
            if (savedPath != null)
            {
                pathTextBox.Text = savedPath;
            }
        }

        private void BrowseButtonClick(object sender, EventArgs e)
        {
            var folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                pathTextBox.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void OkButtonClick(object sender, EventArgs e)
        {
            if (Directory.Exists(pathTextBox.Text))
            {
                SaveSettings();
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Directory not exists.");
            }
        }

        private void CancelButtonClick(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void SaveSettings()
        {
            settingsStorage.SetValue(SettingsKeys.OutputDirectoryKey, pathTextBox.Text);
        }
    }
}
