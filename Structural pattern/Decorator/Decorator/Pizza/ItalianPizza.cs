﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    class ItalianPizza : Pizza
    {
        public ItalianPizza() : base("Итальянская пицца")
        { }
        public override int GetCost()
        {
            return 10;
        }
    }
}
