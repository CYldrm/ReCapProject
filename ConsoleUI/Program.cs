using Business.Concrete;
using DataAccess.Concrete.InMemory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carMananger = new CarManager(new InMemoryCarDal());
            foreach (var car in carMananger.GetAll())
            {
                Console.WriteLine(car.carId);

            }

            Console.ReadLine();
        }
    }
}
