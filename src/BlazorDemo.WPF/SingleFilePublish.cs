using Furion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BlazorDemo.WPF
{
    public class SingleFilePublish: ISingleFilePublish
    {
        public Assembly[] IncludeAssemblies()
        {
            return Array.Empty<Assembly>();
        }

        public string[] IncludeAssemblyNames()
        {
            return new[]
            {
                "BlazorDemo.Application",
                "BlazorDemo.Core",
                "BlazorDemo.Web.Core"
            };
        }
    }
}
