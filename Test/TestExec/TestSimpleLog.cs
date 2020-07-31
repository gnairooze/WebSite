using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestExec
{
    class TestSimpleLog
    {
        public static IConfigurationRoot Configuration;

        public static void TestAddLog1() {
            SimpleLog.Test.TestAddLog1(Configuration.GetConnectionString("LoggingDB"));
        }
    }
}
