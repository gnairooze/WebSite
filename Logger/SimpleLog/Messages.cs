using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleLog
{
    class Messages
    {
        public const string DESCRIPTION_LOG_DISABLED = "log is disabled";
        public const string DESCRIPTION_SETTING_LOG_LEVEL_GREATER_THAN_MODEL_LOG_LEVEL = "setting log level is grater than model log level";

        public const int CODE_LOG_DISABLED = 0;
        public const int CODE_SETTING_LOG_LEVEL_GREATER_THAN_MODEL_LOG_LEVEL = -1;

        public const int CODE_GENERAL_ERROR = -1000;

        public const int CODE_SUCCESS = 1;
    }
}
