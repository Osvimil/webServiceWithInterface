﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRUDwithJSON
{
    public class Productos
    {
        public int id
        {
            get;
            set;
        }

        public string name
        {
            get;
            set;
        }

        public decimal price
        {
            get;
            set;
        }

        public int quantity
        {
            get;
            set;
        }
    }
}