using Microsoft.Extensions.Configuration;
using System;
using System.IO;

namespace TestExec
{
    class Program
    {
        static IConfigurationRoot configuration;
        static void Main(string[] args)
        {
            Configure();

            Start();

            //Console.WriteLine("Press any key to exit ...");
           //Console.Read();
        }

        private static void Configure()
        {
            configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetParent(AppContext.BaseDirectory).FullName)
                .AddJsonFile("appsettings.json", false)
                .Build();
        }

        private static void Start()
        {
            TestSimpleLog.Configuration = configuration;
            TestSimpleLog.TestAddLog1();
        }
    }
}
