using Furion;
using System.Reflection;

namespace BlazorDemo.Web.Entry
{
    public class SingleFilePublish : ISingleFilePublish
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