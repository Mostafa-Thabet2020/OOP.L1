using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.L1.Models
{
    public class Engine
    {
        private int test;//field
        //paroperty 
        public int ID { get; set; }
        public int NumberOfClylinder { get; set; }
        public DateOnly ProductionDate { get; set; }
        public double Power
        {
            //encapsulation 
            get//return data to client to database
            ;

            set// get data from client to database
            ;
        }
        public FuelType fuelType { get; set; }
    }
}
