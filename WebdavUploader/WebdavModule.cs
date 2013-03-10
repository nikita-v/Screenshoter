using Interfaces;
using System;
using System.Windows.Forms;

namespace WebdavUploader
{
    public class WebdavModule : IModule
    {
        private ISettingsStorage settingsStorage;
        private readonly WebdavModuleInfo moduleInfo = new WebdavModuleInfo();

        public void Initialize(ISettingsStorage settingsStorage)
        {
            this.settingsStorage = settingsStorage;
        }

        public DialogResult OpenSettingsWindow()
        {
            return DialogResult.OK;
        }

        public IModuleInfo GetModuleInfo()
        {
            return moduleInfo;
        }

        public bool IsConfigurationNeeded()
        {
            return false;
        }

        public String Upload(String name, Byte[] bytes)
        {
            return null;
        }
    }
}
