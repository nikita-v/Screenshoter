using System;

namespace Interfaces
{
    public interface ISettingsStorage
    {
        String GetValue(String key);
        void SetValue(String key, String value);
    }
}
