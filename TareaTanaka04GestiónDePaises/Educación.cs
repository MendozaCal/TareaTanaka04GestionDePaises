﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaTanaka04GestiónDePaises
{
    internal class Educación:Servicios
    {
        float price;
        int variation;
        public Educación(string name, float price, int variation)
        {
            this.name = name;
            this.price = price;
            this.variation = variation;
        }
        public override float GetPrice()
        {
            return price;
        }
        public override int GetVariationEducacion()
        {
            return variation;
        }
    }
}
