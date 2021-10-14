﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace test2.Classes
{
    public class ProductQueryParameters :QueryParameters
    {
        public string Sku { get; set; }
        public decimal? MinPrice { get; set; }
        public decimal? MaxPrice { get; set; }
        public string Name { get; set; }

        //for advanced search
        public string SearchTerm { get; set; }





    }
}
