using FilesystemUploader.Forms;
using Interfaces;
using System;
using System.IO;
using System.Windows.Forms;

namespace FilesystemUploader
{
    public class FilesystemModule : IModule
    {
        private readonly FilesystemModuleInfo moduleInfo = new FilesystemModuleInfo();
        private ISettingsStorage settingsStorage;

        public void Initialize(ISettingsStorage settingsStorage)
        {
            this.settingsStorage = settingsStorage;
        }

        public DialogResult OpenSettingsWindow()
        {
            return new SettingsForm(settingsStorage).ShowDialog();
        }

        public IModuleInfo GetModuleInfo()
        {
            return moduleInfo;
        }

        public bool IsConfigurationNeeded()
        {
            String outputDirectory = settingsStorage.GetValue(SettingsKeys.OutputDirectoryKey);
            return outputDirectory == null || !Directory.Exists(outputDirectory);
        }

        public String Upload(String name, Byte[] bytes)
        {
            String outputDirectory = settingsStorage.GetValue(SettingsKeys.OutputDirectoryKey);
            using (var fileStream = new FileStream(GetPath(outputDirectory, name), FileMode.Create))
            {
                fileStream.Write(bytes, 0, bytes.Length);
            }
            return GetPath(outputDirectory, name);
        }

        private static String GetPath(String directory, String name)
        {
            return String.Concat(directory, "\\", name);
        }
    }
}