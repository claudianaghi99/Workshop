﻿namespace HelloWorldWeb.services
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class TimeService : ITimeService
    {
        public TimeService()
        {
        }

        public DateTime Now()
        {
            return DateTime.Now;
        }
    }
}
