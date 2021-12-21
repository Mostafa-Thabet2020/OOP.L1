using OOP.L1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.L1
{
    public class DataSeeding
    {
        public DataSeeding()
        {

        }
        public string getNames()
        {
            return "ahhmed";
        }
        //function =>
        //access modifier +return data+ function name 
        public List<Car> getCars()
        {
            //Object declaration 
            Engine EA111 = new Engine() { ID = 1, fuelType = FuelType.Petrol, NumberOfClylinder = 5, ProductionDate = new DateOnly(2005, 5, 20), Power = 15 };//new way
            Engine EA211 = new Engine() { ID = 2, fuelType = FuelType.Petrol, NumberOfClylinder = 7, ProductionDate = new DateOnly(2015, 10, 20), Power = 30 };
            Engine EA888 = new Engine() { ID = 3, fuelType = FuelType.Gaz, NumberOfClylinder = 10, ProductionDate = new DateOnly(2016, 12, 10), Power = 35 };
            Engine testEngine = new Engine();//old way
            testEngine.ID = 4;
            testEngine.ProductionDate = new DateOnly(2021, 5, 15);
            testEngine.Power = 5;
            testEngine.fuelType = FuelType.Petrol;
            testEngine.NumberOfClylinder = 8;

            List<Car> cars = new List<Car>();//list of cars.
            Car VolkswagenAtlas = new Car { ID = 1, carType = CarType.Volkswagen, engine=EA111,Version="atlas" };
            Car VolkswagenJetta = new Car { ID = 2, carType = CarType.Volkswagen, engine=EA211,Version="Jetta" };
            Car VolkswagenTaos = new Car { ID = 3, carType = CarType.BMW, engine=EA211,Version="Taos" };
            Car VolkswagenArteon = new Car { ID = 4, carType = CarType.Audi, engine= testEngine, Version="Arteon" };
            Car BMW = new Car { ID = 5, engine= testEngine, Version="Arteon" };
            //to add objects to list
            cars.Add(VolkswagenArteon);
            cars.Add(VolkswagenTaos);
            cars.Add(VolkswagenAtlas);
            cars.Add(VolkswagenJetta);
            cars.Add(BMW);
            return cars;
        }

    }
}
