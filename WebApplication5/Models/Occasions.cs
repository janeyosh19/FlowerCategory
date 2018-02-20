using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WebApplication5.Models
{
    public class Occasion
    {   
       public int OccasionId { get; set; }
        public virtual List<Flower> Flowers { get; set; }
        public virtual List<Wrapping> Wrappings { get; set; }
        public virtual List<Card> Cards { get; set; }
        
    }


    public class OccasionsContext: DbContext
    {   
        
        public DbSet<Flower> Flowers { get; set; }
        public DbSet<Wrapping> Wrappings { get; set; }
        public DbSet<Card> Cards { get; set; }

    }


}