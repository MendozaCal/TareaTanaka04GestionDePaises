﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaTanaka04GestiónDePaises
{
    internal class Seguridad:Servicios
    {
        float price;
        int variation;
        public Seguridad(string name, float price, int variation)
        {
            this.name = name;
            this.price = price;
            this.variation = variation;
        }
        public override float GetPrice()
        {
            return price;
        }
        public override int GetVariationSeguridad()
        {
            return variation;
        }
    }
}
