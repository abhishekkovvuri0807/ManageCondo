﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManageCondo.Models
{
    public class PropertyViewModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public string Email { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }

    }
}
