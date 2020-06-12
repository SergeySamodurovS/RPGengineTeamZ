using System;
using System.Collections.Generic;
using System.Text;

namespace Engine
{
    public class Mana
    {
        public int Blue { get; set; }
        public void PayFor(Mana cost)
        {
            if (cost.Blue > 0) Blue -= cost.Blue;

        }
    }
}
