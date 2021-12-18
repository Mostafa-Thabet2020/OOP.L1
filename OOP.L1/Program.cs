// See https://aka.ms/new-console-template for more information
using OOP.L1;
using OOP.L1.Objs;

// OOP = object oriented programming // ar البرمجة الشئية
// Object,function
// List,Property,encupsolation,inherment,enum
// static, polymorphism, interface, abstract

List<int> ages = new();// قائمة ارقام صحيح
ages.Add(5);
ages.Add(6);
ages.Add(7);

for (int i = 0; i < ages.Count; i++)
{
   Console.WriteLine(ages[i]);
}


List<string> names = new List<string>();//obvious versions
List<string> types = new ();//c#11
int listlenght = names.Count();// lenght

DataSeeding Data = new DataSeeding();//instance from DataSeeding class to get data.
List<Car> cars = Data.getCars();// get data from function to new list.

foreach (var car in cars)
{
    Console.WriteLine("Version is " + car.Version + "\nCar type is " + car.carType);//   /n mean new line
    Console.WriteLine("number of Clynder " + car.engine.NumberOfClylinder + "\ndate of production " + car.engine.ProductionDate);
    Console.WriteLine("----------------");
}

for (int i = 0; i < cars.Count; i++)//looping on list of car
{
    Console.WriteLine(cars[i].GetAllDescription());
}
Console.ReadLine();