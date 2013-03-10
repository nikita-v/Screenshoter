using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using Interfaces;

namespace Core.Modules
{
    public class ModulesManager
    {
        private readonly Dictionary<String, IModule> modules = new Dictionary<String, IModule>();

        public ModulesManager()
        {
            LoadModules();
        }

        public List<IModuleInfo> GetModulesInfo()
        {
            return modules.Values.Select(module => module.GetModuleInfo()).ToList();
        }

        public IModule GetModuleByGuid(String guid)
        {
            if (modules.ContainsKey(guid))
            {
                return modules[guid];
            }
            return null;
        }

        private void LoadModules()
        {
            foreach (FileInfo file in GetFileList())
            {
                LoadModule(file.FullName);
            }
        }

        private void LoadModule(String filename)
        {
            try
            {
                Assembly assembly = Assembly.LoadFile(filename);
                foreach (Type type in assembly.GetTypes())
                {
                    if (type.GetInterface(typeof (IModule).FullName) != null)
                    {
                        var moduleInstance = (IModule) Activator.CreateInstance(type);
                        string moduleGuid = moduleInstance.GetModuleInfo().GetModuleGuid().ToString();
                        moduleInstance.Initialize(new ModuleSettingsStorage(moduleGuid));
                        modules.Add(moduleGuid, moduleInstance);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private static IEnumerable<FileInfo> GetFileList()
        {
            var pluginsDirectory = new DirectoryInfo(GetModulesPath());
            var files = new List<FileInfo>();
            files.AddRange(pluginsDirectory.GetFiles("*.dll"));
            return files;
        }

        private static string GetModulesPath()
        {
            string executablePath = Path.GetDirectoryName(Application.ExecutablePath);
            return executablePath != null ? Path.Combine(executablePath, "modules") : null;
        }
    }
}