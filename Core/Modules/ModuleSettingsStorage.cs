using System.Configuration;
using Interfaces;
using System;

namespace Core.Modules
{
    class ModuleSettingsStorage : ISettingsStorage
    {
        //private static readonly 

        private String Guid
        {
            get;
            set;
        }

        public ModuleSettingsStorage(String guid)
        {
            Guid = guid;
        }

        public String GetValue(String key)
        {
            var moduleSection = GetModuleSection(GetConfiguration());
            return moduleSection.Settings[key] == null ? null : moduleSection.Settings[key].Value;
        }

        public void SetValue(String key, String value)
        {
            var configuration = GetConfiguration();
            var moduleSection = GetModuleSection(configuration);
            if (moduleSection.Settings[key] == null)
            {
                moduleSection.Settings.Add(key, value);
            }
            else
            {
                moduleSection.Settings[key].Value = value;
            }
            SaveConfiguration(configuration);
        }

        private Configuration GetConfiguration()
        {
            return ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.PerUserRoaming);
        }

        private void SaveConfiguration(Configuration configuration)
        {
            configuration.Save(ConfigurationSaveMode.Modified, true);
        }

        private AppSettingsSection GetModuleSection(Configuration configuration)
        {
            var section = (AppSettingsSection) configuration.GetSection(Guid);
            if (section == null)
            {
                var newSection = new AppSettingsSection();
                newSection.SectionInformation.AllowExeDefinition = ConfigurationAllowExeDefinition.MachineToRoamingUser;
                configuration.Sections.Add(Guid, newSection);
                section = newSection;
            }
            return section;
        }
    }
}
