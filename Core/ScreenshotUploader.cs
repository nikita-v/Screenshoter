using System.ComponentModel;
using System.Windows.Forms;
using Core.Forms;
using Core.Modules;
using Core.Properties;
using Interfaces;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace Core
{
    class ScreenshotUploader
    {
        private readonly ModulesManager modulesManager;

        public ScreenshotUploader(ModulesManager modulesManager)
        {
            this.modulesManager = modulesManager;
        }

        public void Upload(Bitmap bitmapToUpload)
        {
            while (IsRequireModulesSettings())
            {
                new SettingsForm(modulesManager).ShowModulesDialog();
            }
            IModule moduleInstance = modulesManager.GetModuleByGuid(Settings.Default.ActiveModuleGuid);
            if (!moduleInstance.IsConfigurationNeeded() || moduleInstance.OpenSettingsWindow() == DialogResult.OK)
            {
                StartAsyncUploading(moduleInstance, GetFilename(), GetBitmapBytes(bitmapToUpload));   
            }
        }

        private void StartAsyncUploading(IModule uploader, String name, byte[] bytes)
        {
            var backgroundWorker = new BackgroundWorker();
            backgroundWorker.DoWork += (s, e) => e.Result = uploader.Upload(name, bytes);
            backgroundWorker.RunWorkerCompleted += (s, e) => Clipboard.SetText((String) e.Result);
            backgroundWorker.RunWorkerAsync();
        }

        private byte[] GetBitmapBytes(Bitmap bitmap)
        {
            byte[] byteArray;
            using (var memoryStream = new MemoryStream())
            {
                bitmap.Save(memoryStream, ImageFormat.Png);
                byteArray = memoryStream.ToArray();
            }
            return byteArray;
        }

        private String GetFilename()
        {
            DateTime timestamp = DateTime.Now;
            String format = String.Concat("{0:", Settings.Default.FilenamePattern, "}.png");
            return String.Format(format, timestamp);//dd-MM-yyyy_HH-mm-ss
        }

        private Boolean IsRequireModulesSettings()
        {
            return Settings.Default.ActiveModuleGuid == null ||
                modulesManager.GetModuleByGuid(Settings.Default.ActiveModuleGuid) == null;
        }
    }
}
