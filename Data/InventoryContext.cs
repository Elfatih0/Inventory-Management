using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System;
using InventoryManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace InventoryManagement.Data
{
    public class InventoryContext:DbContext
    {

        public InventoryContext(DbContextOptions options):base(options)
        {

        }
        
        

        public virtual DbSet<Unit> Units { get; set; }

    }
}
