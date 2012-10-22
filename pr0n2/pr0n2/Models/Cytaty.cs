using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace pr0n2.Models
{
    public class Cytaty
    {
        public int ID { get; set; }
        public string Text { get; set; }
        public DateTime Date { get; set; }
        public int Rate { get; set; }
    }
    public class CytatyDBContext : DbContext
    {
        public DbSet<Cytaty> Cytat { get; set; }
    }
}