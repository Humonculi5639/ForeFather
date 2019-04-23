﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ForeFather
{
    class Crystal : Item
    {
        private int mana;
        public int Mana
        {
            get { return mana; }
            set { mana = value; }
        }

        public Crystal(string n, string d, int magnitude) : base(n, d + "\r\nThe crystal stores " + magnitude + "extra mana")
        {
            mana = magnitude;
        }

        override
        public Ally Use(Ally c)
        {
            //placeholder
            return c;
        }

        override
        public bool Equals(Item item)
        {
            return item.Name == this.Name && ((Crystal)item).Mana == this.Mana;
        }
    }
}