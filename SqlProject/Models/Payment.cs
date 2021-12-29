using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SqlProject.Models
{
    public class Payment
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Cost { get; set; }
        public string Possible { get; set; }
        public string Link { get; set; }


    }
}
