﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace test2.Models
{
    public class User
    {
        public int Id { get; set; }
        public String Email { get; set; }
        public virtual List<Order> Orders { get; set; }



    }
}
