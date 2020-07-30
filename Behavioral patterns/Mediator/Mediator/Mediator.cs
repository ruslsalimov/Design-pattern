﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator
{
    abstract class Mediator
    {
        public abstract void Send(string msg, Colleague colleague);
    }
}
