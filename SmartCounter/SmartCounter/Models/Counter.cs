﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SmartCounter.Models
{
    public class Counter
    {
        public int Count { get; set; } = 0;
      

        public void SetCounterToZero(Counter counter)
        {
            counter.Count = 0;
        }
    }
}
