﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    internal class SupCard : Card
    {
        // TODO: types of supcard classes:
        // DurabilityBoost
        // AtkBoost
        // Turn
        private int value;

        public int Value
        {
            get { return value; }
        }
    }
}
