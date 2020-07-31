using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleLog
{
    public interface IDataBasic
    {
        string LogDbConnectionString { get; set; }
        Basics.Result Add(LogInterface.LogModel model);
    }
}
