using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //CarManager carManager = new CarManager(new EfCarDal(),);
            //var result = carManager.GetAll();
            //if(result.Success)
            //{
            //    foreach (var car in result.Data)
            //    {
            //        Console.WriteLine(car.Id + " " + car.BrandId+ " " + car.Description + " " + car.DailyPrice);
            //    }
            //}
            //else
            //{
            //    Console.WriteLine(result.Message);
            //}


            //carManager.Delete(car);

        }
    }
}
