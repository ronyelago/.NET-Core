using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace Core
{
    class Program
    {
        static void Main(string[] args)
        {
            var hosting = new WebHostBuilder()
                .UseKestrel()
                .Configure(
                    app => {
                        app.Run(context => context.Response.WriteAsync("oi meu chapa"));
                    }
                )
                .Build();

            hosting.Run();
        }
    }
}
