﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NTT_Shop.Models.Entities
{
    public class ProductRates
    {
        public int idProduct { get; set; }
        public int idRate { get; set; }
        public Decimal price { get; set; }
    }
}