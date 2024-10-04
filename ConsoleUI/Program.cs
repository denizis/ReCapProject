using Business.Concrete;
using DataAccess.Concrete;
using Entities.Concrete;
using System;
using Business.Abstract;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            Car car1 = new Car();
            car1.CarId = 8;
            car1.BrandId = 9;
            car1.ColorId = 30;
            car1.DailyPrice = 1500;
            car1.Description = "Araba Bmw 320i";
            car1.ModelYear = 2023;


            CarManager carManager = new CarManager(new InMemoryCarDal());



         
            InMemoryCarDal memory = new InMemoryCarDal();
            memory.Add(car1);

            memory.Update(car1);
            memory.Delete(car1);







            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("ModelNo");
                Console.WriteLine(car.CarId + "            " + car.Description);
                Console.WriteLine("----------------------------------------------------------------");
            }







            Console.Read();
        }
    }
}
