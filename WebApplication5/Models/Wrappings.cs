using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;



namespace WebApplication5.Models
{
    public class Wrapping
    {
        public int WrappingId { get; set; }
        public string WrapperName { get; set; }


        public Wrapping(string name)
            {

            this.WrapperName = name;
            }
    }
}