using Newtonsoft.Json.Linq;
using System;

namespace Basics
{
    public class Result
    {
        public Enums.Status ResultStatus { get; set; }
        public int Code { get; set; }
        public string Description { get; set; }
        public JObject Data { get; set; }
    }
}
