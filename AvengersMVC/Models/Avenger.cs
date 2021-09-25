using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AvengersMVC.Models
{
    public class Avenger
    {
        public int Id { get; set; }
        public string SuperheroName { get; set; }
        public string RealName { get; set; }
        public string Weapons { get; set; }
        public bool CanFly { get; set; }
        public string ImageUrl { get; set; }
    }
}
