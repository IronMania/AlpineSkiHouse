using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace AlpineSkiHouse
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();

        }
        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .Build();
    }
}
