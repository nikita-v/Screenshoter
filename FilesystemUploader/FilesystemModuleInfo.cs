using Interfaces;
using System;

namespace FilesystemUploader
{
    class FilesystemModuleInfo : IModuleInfo
    {
        public Guid GetModuleGuid()
        {
            return Guid.Parse("AA6D27DA-77F1-4474-9AD8-B2EC671E8FFC");
        }

        public String GetModuleName()
        {
            return "Filesystem saver";
        }

        public String GetModuleDescription()
        {
            return "Save screenshots to the filesystem.";
        }

        public String GetModuleAuthor()
        {
            return "Nikita Vorobej";
        }

        public String GetModuleVersion()
        {
            return "1.0";
        }

        public String GetModuleServiceUrl()
        {
            return "http://nikita-v.ru";
        }

        public Boolean GetIsConfigurable()
        {
            return true;
        }
    }
}
