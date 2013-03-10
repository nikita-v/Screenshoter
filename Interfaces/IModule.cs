using System;
using System.Windows.Forms;

namespace Interfaces
{
    public interface IModule
    {
        void Initialize(ISettingsStorage settingsStorage);
        DialogResult OpenSettingsWindow();
        IModuleInfo GetModuleInfo();
        Boolean IsConfigurationNeeded();
        String Upload(String name, Byte[] bytes);
    }
}
