﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoStorage.Data
{
    /**
     * Абстрактный класс груз
     * 
     */
    public abstract class ACargo
    {
        private string name = string.Empty;

        private string description = string.Empty;

        public string Name { get { return name; } set { name = value; } }

        public string Description { get { return description; } set { description = value; } }

    }
}
