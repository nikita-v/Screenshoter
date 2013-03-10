using System;

namespace Interfaces
{
    public interface IModuleInfo
    {
        Guid GetModuleGuid();
        String GetModuleName();
        String GetModuleDescription();
        String GetModuleAuthor();
        String GetModuleVersion();
        String GetModuleServiceUrl();
        Boolean GetIsConfigurable();
    }
}
