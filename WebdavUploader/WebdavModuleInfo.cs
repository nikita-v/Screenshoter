using Interfaces;
using System;

namespace WebdavUploader
{
    class WebdavModuleInfo : IModuleInfo
    {
        public Guid GetModuleGuid()
        {
            return Guid.Parse("AFBEFA53-42C6-4B62-BA6D-F1059DBA393A");
        }

        public String GetModuleName()
        {
            return "Webdav uploader";
        }

        public String GetModuleDescription()
        {
            return "Upload screenshots using webdav protocol.";
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
