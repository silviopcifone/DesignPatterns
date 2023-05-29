﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternExample.model
{
    internal interface ISubscriber
    {
        public void update(Publisher context);
    }
}
