﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace test2.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Sku { get; set; }
        public string Name { get; set; }
        public String Description { get; set; }
        public decimal Price { get; set; }
        public bool IsAvailabel { get; set; }

        [JsonIgnore]
        public virtual Category Category  { get; set; }


    }
}
