using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

            
 
Host.CreateDefaultBuilder(args)
            .ConfigureWebHostDefaults(webBuilder =>
            {
               webBuilder.Configure(app =>
               {
                   app.Run(async context =>
                   {
                      await Task.Delay(TimeSpan.FromSeconds(10));


                       await context.Response.WriteAsync
                         ("Hello World ");
                       
                   });
               });
            })
        .Build().Run();
