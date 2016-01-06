using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PersonalWebSiteAPI.Models
{
    public class Persion
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Commodity { get; set; }
        public decimal Price { get; set; }
    }
}