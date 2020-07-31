using System;
using System.Collections.Generic;
using System.Text;

namespace Basics
{
    public class Enums
    {
        public enum Status { 
            NotSet = 0,
            Succeeded = 1,
            Failed = 2,
            Skipped = 4,
            Canceled = 8,
            Processing = 16,
            Stalled = 32
        }
    }
}
