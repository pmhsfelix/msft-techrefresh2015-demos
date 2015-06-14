using System;
using Microsoft.Framework.DependencyInjection;
using Microsoft.Framework.Runtime;
using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Http;

namespace First
{
	public class Startup
	{
		public void ConfigureServices(IServiceCollection services)
		{

		}

		public void Configure(IApplicationBuilder app)
		{
			app.Run(async (context) =>
	        {                
	        	context.Response.Headers["Content-type"] = "text/plain";
	        	await context.Response.WriteAsync("Hello Web!");
	        });
		}

	}
}