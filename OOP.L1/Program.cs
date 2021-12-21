// See https://aka.ms/new-console-template for more information
using OOP.L1;
using OOP.L1.Models;

// OOP = object oriented programming // ar البرمجة الشئية
// Object,function
// List,Property,encupsolation,inherment,enum , function
// static, polymorphism, interface, abstract

//List<int> ages = new();// قائمة ارقام صحيح
//ages.Add(5);
//ages.Add(6);
//ages.Add(7);

//for (int i = 0; i < ages.Count; i++)
//{
//   Console.WriteLine(ages[i]);
//}


//List<string> names = new List<string>();//obvious versions
//List<string> types = new ();//c#11
//int listlenght = names.Count();// lenght

DataSeeding Data = new DataSeeding();//instance from DataSeeding class to get data.
List<Car> cars = Data.getCars();// get data from function to new list.

foreach (Car car in cars)//get each car from cars list
{
    Console.WriteLine("Version is " + car.Version + "\nCar type is " + car.carType);//   /n mean new line
    Console.WriteLine("number of Clynder " + car.engine.NumberOfClylinder + "\ndate of production " + car.engine.ProductionDate);
    Console.WriteLine("----------------");
}
//code that will done before looping int i = 0;
//condation if this condation true loop else break loop
// add 1 to i ex: i++
for (int i = 0; i < cars.Count; i++)//looping on list of car
{
    Console.WriteLine(cars[i].GetAllDescription());
}

/// <summary>
/// to get data where condation from list
/// </summary>
///          List name+list fuction(x= parameter from list than condation ) if this selection is list user to list()
//function arrow
List<Car> Volks = cars.Where(x => x.carType == CarType.Volkswagen).ToList();//lambada exerpation
Console.WriteLine("_____________\n\nVolks Loop");
foreach (Car car in Volks)
{
    Console.WriteLine($"car name ={car.Version}\n" +
        $"car type is: {car.carType}");
}
//SingleOrDefault => in unique value cases(id)
//FirstOrDefualt => if the value is not unquie fet first object
//LastOrDefualt => if the value is not unquie fet last object
Car Taos = cars.Where(x => x.ID == 3).SingleOrDefault();// select sapcific item.
Console.WriteLine($"\nTaos engine power is {Taos.engine.Power}, car type is {Taos.carType}");

int NumberOfClynder = cars.Where(x => x.ID == 4).Select(x => x.engine.NumberOfClylinder).SingleOrDefault();
Console.WriteLine(string.Concat("NumberOfClynder is ", NumberOfClynder));

Car LastVolks = (from x in cars
                 where x.carType == CarType.Volkswagen && x.carType!=null
                 select x).LastOrDefault();
Console.WriteLine($"\nLast Volks car version is {LastVolks.Version}\n" +
    $"engine power is {LastVolks.engine.Power}");

string FirstVersion = (from x in cars
                       where x.carType.Value == CarType.Volkswagen
                       select x.Version).FirstOrDefault();
Console.WriteLine("First Version of Volks is " + FirstVersion);

Car CarWithoutType = (from x in cars
                      where !x.carType.HasValue
                      select x).FirstOrDefault();
Console.WriteLine("\nCarWithoutType " + CarWithoutType.Version);

Console.ReadLine();