﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreMVC2.introduction.Services
{
    public class Calculate8 : ICalculator
    {
        public decimal Caltulate(decimal amaount)
        {
            return amaount + (amaount * 8 / 100);
        }
    }
}
