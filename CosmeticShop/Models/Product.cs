using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CosmeticShop.Models
{
    public class Product
    {
        public string Id { get; set; }
        public string ShortName { get; set; }
        public string FullName { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }

        //picture

        public string IdGroup { get; set; }
        public string IdCategory { get; set; }

    }
}