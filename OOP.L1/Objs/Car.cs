using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.L1.Objs
{
    public class Car:Transport
    {
        public string? Version { get; set; }
        public CarType? carType { get; set; } //= CarType.BMW;
        public Engine? engine { get; set; } // object
        private string GetCarDescription()//function return string.
        {
            return $"Car details\n--------\nCar type is {carType}\ncar version is {Version}";
        }
        private string GetEngineDescription()
        {
            return $"Engine details\n -------- \nnumber of clylindersis {engine.NumberOfClylinder}\n" +
                $"prodaction date is {engine.ProductionDate}" ;
        }
        public string GetAllDescription()
        {
            return string.Concat(GetCarDescription(),"\n_______\n",GetEngineDescription(),"\n____________________________\n");
        }
    }
}
