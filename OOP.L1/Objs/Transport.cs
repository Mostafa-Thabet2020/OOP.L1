using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.L1.Objs
{
    public class Transport
    {
        public int ID { get; set; }//id for perfect call(unique) فريدة غير مكررة
        public string? Name { get; set; }
        public string color { get; set; }
        public static int TransportCount { get; set; }
        public virtual int GetTransportCount()
        {
            return TransportCount;
        }
    }
}
