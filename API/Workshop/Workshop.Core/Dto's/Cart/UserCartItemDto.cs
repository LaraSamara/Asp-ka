﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop.Core.Dto_s.Cart
{
    public class UserCartItemDto
    {
        public string Name { get; set; }
        public double Quantity { get; set; }
        public double Price { get; set; }
        public string Unit  {  get; set; }
    }
}