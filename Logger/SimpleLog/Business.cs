using LogInterface;
using System;

namespace SimpleLog
{
    public class Business : ILog
    {
        public Enums.LogLevels LogLevelSetting { get; set; }
        public bool Enabled { get; set; }

        public IDataBasic Data { get; set; }
        
        public Business(IDataBasic data)
        {
            this.Data = data;
        }

        public Basics.Result Add(LogModel model)
        {
            if (!this.Enabled)
            {
                return new Basics.Result() { 
                    Code = Messages.CODE_LOG_DISABLED,
                    Description = Messages.DESCRIPTION_LOG_DISABLED,
                    ResultStatus = Basics.Enums.Status.Skipped
                };
            }
            if(this.LogLevelSetting > model.LogLevel)
            {
                return new Basics.Result()
                {
                    Code = Messages.CODE_SETTING_LOG_LEVEL_GREATER_THAN_MODEL_LOG_LEVEL,
                    Description = Messages.DESCRIPTION_SETTING_LOG_LEVEL_GREATER_THAN_MODEL_LOG_LEVEL,
                    ResultStatus = Basics.Enums.Status.Skipped
                };
            }

            return this.Data.Add(model);
        }
    }
}
