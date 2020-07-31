using System;
using System.Collections.Generic;
using System.Text;

namespace LogInterface
{
    public class LogModel
    {
        public long ID { get; set; }
        public DateTime CreateDate { get; set; }
        public Enums.LogLevels LogLevel { get; set; }
        public Guid CorrelationID { get; set; }
        public int Step { get; set; }
        public string Who { get; set; }
        public string Message { get; set; }
        public string RefName { get; set; }
        public string RefValue { get; set; }
        public string Path { get; set; }
        public string Assembly { get; set; }
        public string ClassName { get; set; }
        public string MethodName { get; set; }
        public string IP { get; set; }
        public Uri URL { get; set; }
        public string Notes1 {get;set;}
        public string Notes2 { get; set; }
    }
}
