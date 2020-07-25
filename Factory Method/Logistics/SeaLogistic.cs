﻿using Factory_Method.Transports;

namespace Factory_Method.Logistics
{
    class SeaLogistic : Logistic
    {
        public override Transport CreateTransport()
        {
            return new Ship();
        }
    }
}
