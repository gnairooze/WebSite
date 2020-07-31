using System;

namespace LogInterface
{
    public interface ILog
    {
        bool Enabled { get; set; }
        Enums.LogLevels LogLevelSetting { get; set; }

        Basics.Result Add(LogModel model);
    }
}
