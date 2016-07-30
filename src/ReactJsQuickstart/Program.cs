﻿using System;
using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace ReactJsQuickstart.ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var host = new WebHostBuilder()
                        .UseKestrel()
                        .UseWebRoot("public")
                        .UseContentRoot(Directory.GetCurrentDirectory())
                        .UseStartup<Startup>()
                        .Build();

            host.Run();
        }
    }
}
