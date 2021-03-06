﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Http;
using Microsoft.Framework.DependencyInjection;
using Microsoft.Framework.Logging;
using Microsoft.Framework.Runtime;

namespace HelloWebFromVs
{
    public class Startup
    {
        // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<object, object>();
        }

        public void Configure(IApplicationBuilder app, ILoggerFactory factory)
        {
            factory.AddConsole();
            //app.UseWelcomePage();
            app.Run(async (context) =>
            {                
                await context.Response.WriteAsync("Hello World!");
            });
        }
    }
}
