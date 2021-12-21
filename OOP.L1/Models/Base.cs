using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.L1.Models
{
    public class Base
    {
        public int ID { get; set; }//id for perfect call(unique) فريدة غير مكررة
        public DateOnly CreatedDate { get; set; }
    }
}
