using Business.Concrete;
using DataAccess.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description);
            }

            carManager.Add(new Entities.Concrete.Car { BrandId = 2, ColorId = 1, DailyPrice = 150, Description = "VW Polo 1.2 TDI", ModelYear = 2012 });
            carManager.Add(new Entities.Concrete.Car { BrandId = 3, ColorId = 2, DailyPrice = 200, Description = "Hyundai i20", ModelYear = 2018 });
            carManager.Add(new Entities.Concrete.Car { BrandId = 1, ColorId = 3, DailyPrice = 100, Description = "Renault Clio", ModelYear = 2007 });
        }
    }
}
