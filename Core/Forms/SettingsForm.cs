using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Core.Controls;
using Core.Modules;
using Core.Properties;
using Interfaces;

namespace Core.Forms
{
    public partial class SettingsForm : Form
    {
        private readonly List<IModuleInfo> modulesInfo;
        private readonly ModulesManager modulesManager;

        public SettingsForm(ModulesManager modulesManager)
        {
            this.modulesManager = modulesManager;
            modulesInfo = modulesManager.GetModulesInfo();
            InitializeComponent();
            LoadSettings();
            ApplyAlpha();
            LoadModules();
        }

        public DialogResult ShowModulesDialog()
        {
            tabControl.SelectedIndex = 1;
            return ShowDialog();
        }

        private void LoadSettings()
        {
            filenamePatternTextBox.Text = Settings.Default.FilenamePattern;
            backgroundColorView.CurrentColor = Settings.Default.SelectedBackgroundColor;
            borderColorView.CurrentColor = Settings.Default.SelectedBorderColor;
            borderAlpha.Value = Settings.Default.SelectedBorderColor.A;
            penColorView.CurrentColor = Settings.Default.PenColor;
            penAlpha.Value = Settings.Default.PenColor.A;
            penWidthTextBox.Value = Settings.Default.PenWidth;
        }

        private void LoadModules()
        {
            String actimeModuleGuid = Settings.Default.ActiveModuleGuid;
            foreach (IModuleInfo moduleInfo in modulesInfo)
            {
                bool isActive = moduleInfo.GetModuleGuid().ToString().Equals(actimeModuleGuid);
                modulesList.Items.Add(moduleInfo.GetModuleName(), isActive);
                if (isActive)
                {
                    modulesList.SelectedIndex = modulesList.Items.Count - 1;
                }
            }
        }

        private void ModulesListSelectionChanged(object sender, EventArgs e)
        {
            if (modulesList.SelectedIndex < 0)
            {
                return;
            }
            IModuleInfo selectedModuleInfo = GetSelectedModuleInfo();
            moduleName.Text = selectedModuleInfo.GetModuleName();
            moduleDescription.Text = selectedModuleInfo.GetModuleDescription();
            moduleAuthor.Text = selectedModuleInfo.GetModuleAuthor();
            moduleVersion.Text = selectedModuleInfo.GetModuleVersion();
            moduleUrl.Text = selectedModuleInfo.GetModuleServiceUrl();
            moduleSettingsButton.Enabled = selectedModuleInfo.GetIsConfigurable();
        }

        private void ModuleSettingsButtonClick(object sender, EventArgs e)
        {
            IModuleInfo selectedModuleInfo = GetSelectedModuleInfo();
            IModule moduleInstance = modulesManager.GetModuleByGuid(selectedModuleInfo.GetModuleGuid().ToString());
            moduleInstance.OpenSettingsWindow();
        }

        private void ModulesListItemCheck(object sender, ItemCheckEventArgs e)
        {
            for (int i = 0; i < modulesList.Items.Count; ++i)
            {
                if (i != e.Index)
                {
                    modulesList.SetItemChecked(i, false);
                }
            }
        }

        private void SelectColorButtonClick(object sender, EventArgs e)
        {
            var senderControl = (ColorViewControl) sender;
            senderControl.CurrentColor = SelectColor(senderControl.CurrentColor);
        }

        private static Color SelectColor(Color color)
        {
            var colorDialog = new ColorDialog {Color = color, AnyColor = true};
            colorDialog.ShowDialog();
            return colorDialog.Color;
        }

        private void AlphaChanged(object sender, EventArgs e)
        {
            ApplyAlpha();
        }

        private void ApplyAlpha()
        {
            borderColorView.CurrentColor = Color.FromArgb((int) borderAlpha.Value, borderColorView.CurrentColor);
            penColorView.CurrentColor = Color.FromArgb((int) penAlpha.Value, penColorView.CurrentColor);
        }

        private void OkButtonClick(object sender, EventArgs e)
        {
            SaveSettings();
            DialogResult = DialogResult.OK;
            Close();
        }

        private void CancelButtonClick(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void SaveSettings()
        {
            ApplyAlpha();
            Settings.Default.FilenamePattern = filenamePatternTextBox.Text;
            Settings.Default.SelectedBackgroundColor = backgroundColorView.CurrentColor;
            Settings.Default.SelectedBorderColor = borderColorView.CurrentColor;
            Settings.Default.PenColor = penColorView.CurrentColor;
            Settings.Default.PenWidth = (int) penWidthTextBox.Value;
            if (modulesList.CheckedIndices.Count != 0)
            {
                IModuleInfo checkedModuleInfo = modulesInfo[modulesList.CheckedIndices[0]];
                Settings.Default.ActiveModuleGuid = checkedModuleInfo.GetModuleGuid().ToString();
            }
            Settings.Default.Save();
        }

        private IModuleInfo GetSelectedModuleInfo()
        {
            return modulesInfo[modulesList.SelectedIndex];
        }
    }
}