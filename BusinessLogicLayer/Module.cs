using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace milestoneTwo.BusinessLogicLayer
{
    internal class Module
    {
        string moduleCode, moduleName, moduleDescription, onlineResources;

        public Module(string moduleCode, string moduleName, string moduleDescription, string onlineResources)
        {
            this.moduleCode = moduleCode;
            this.moduleName = moduleName;
            this.moduleDescription = moduleDescription;
            this.onlineResources = onlineResources;
        }

        public string ModuleCode { get => moduleCode; set => moduleCode = value; }
        public string ModuleName { get => moduleName; set => moduleName = value; }
        public string ModuleDescription { get => moduleDescription; set => moduleDescription = value; }
        public string OnlineResources { get => onlineResources; set => onlineResources = value; }
    }
}
