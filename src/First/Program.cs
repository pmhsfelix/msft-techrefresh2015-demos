using System;
using Microsoft.Framework.DependencyInjection;
using Microsoft.Framework.Runtime;

namespace First
{
	public class Program
	{
		private readonly IServiceProvider _services;

		public Program(IServiceProvider services)
		{
			_services = services;
		}

		public void Main(String[] args)
		{
			Console.WriteLine("Hello World, here is first");

			var env = _services.GetService(typeof(IApplicationEnvironment)) as IApplicationEnvironment;
            Console.WriteLine("{0},{1}",env.Configuration, env.RuntimeFramework.FullName);
		}
	}	
}