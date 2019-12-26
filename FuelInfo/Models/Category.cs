using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FuelInfo.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public float Price { get; set; }
        public string Date { get; set; }

    }
}