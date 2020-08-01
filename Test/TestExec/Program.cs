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
            var testOption = configuration.GetSection("testOption").Value;

            switch (testOption)
            {
                case TestOptions.TEST_OPTION_LOG:
                    TestSimpleLog.TestAddLog1();
                    break;
                case TestOptions.TEST_OPTION_SENDGRID:
                    TestSendGrid.Execute().Wait();
                    break;
            }
        }
    }
}
