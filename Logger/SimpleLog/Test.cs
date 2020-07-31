using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleLog
{
    public class Test
    {
        public static void TestAddLog1(string connectionString)
        {
            Business business = new Business(new DataSQL() { LogDbConnectionString = connectionString}) { 
            Enabled = true,
            LogLevelSetting = LogInterface.Enums.LogLevels.Debug
            };

            Basics.Result result = business.Add(new LogInterface.LogModel()
            {
                Assembly = "Test Assembly",
                ClassName = "Test Class",
                CorrelationID = Guid.NewGuid(),
                CreateDate = DateTime.Now,
                IP = "0.0.0.0",
                LogLevel = LogInterface.Enums.LogLevels.Info,
                Message = "TestAddLog1",
                MethodName = "Test Method Name",
                Notes1 = "Test Notes 1",
                Notes2 = "Test Notes2",
                Path = @"C:\DIR1\DIR2",
                RefName = "Test Ref Name",
                RefValue = "Test Ref Value",
                Step = 3,
                URL = new Uri("https://www.test.com"),
                Who = "Self Test Class"
            }) ;

            Console.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(result));
        }
    }
}
