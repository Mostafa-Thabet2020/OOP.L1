using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.L1.Models
{
    public class Transport:Base
    {
        public string? Name { get; set; }
        public string color { get; set; }
        public static int TransportCount { get; set; }
        public virtual int GetTransportCount()
        {
            return TransportCount;
        }
    }
}
