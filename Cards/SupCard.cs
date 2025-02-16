﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    internal class SupCard : Card
    {
        public SupCard () {
            name = "Support";
            description = "Heals one attack card to full durability.";
            color = Color.Green;
            card_value = 5;
        }

        public int Value
        {
            get { return card_value; }
        }
    }
}
