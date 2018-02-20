using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication5.Models;

namespace WebApplication5.Models
{
    public class Flower
    {
        
            public int FlowerId { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
            public double Cost { get; set; }
            public int Quantity { get; set; }
            public byte[] Image { get; set; }


        public Flower(string name)
        {
            this.Name = name;
            //this.Cost = cost;
            //this.Description = description;

        }
         public FlowerType FlowerType { get; set; }    
            
        
    }
}