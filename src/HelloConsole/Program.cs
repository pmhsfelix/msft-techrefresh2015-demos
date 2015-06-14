using Microsoft.Framework.Runtime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloConsole
{
    public class Program
    {
        private readonly IServiceProvider _services;

        public Program(IServiceProvider services)
        {
            _services = services;
        }

        public void Main(string[] args)
        {
            var env = _services.GetService(typeof(IApplicationEnvironment)) as IApplicationEnvironment;
            Console.WriteLine("Hello console, {0}, {1}",env.Configuration, env.RuntimeFramework.FullName);
        }
    }
}
