using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace FuelInfo.Models
{
    public class ContextClass : DbContext
    {
        public DbSet<Category> Categories { get; set; }

    }
}