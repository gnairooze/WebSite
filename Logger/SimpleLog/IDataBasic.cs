using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleLog
{
    public interface IDataBasic
    {
        Basics.Result Add(LogInterface.LogModel model);
    }
}
