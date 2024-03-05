using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> cars;

        public InMemoryCarDal()
        {
            cars = new List<Car>
            {
            new Car{ carId = 1, BrandId = 1, ColorId = 1, ModelYear = "2022", DailyPrice = 150, Description  = "Araba 1 Açıklama" },
            new Car{ carId = 2, BrandId = 2, ColorId = 2, ModelYear = "2021", DailyPrice = 120, Description  = "Araba 2 Açıklama" },
            new Car{ carId = 3, BrandId = 3, ColorId = 3, ModelYear = "2020", DailyPrice = 100, Description  = "Araba 3 Açıklama" },
            new Car{ carId = 4, BrandId = 1, ColorId = 4, ModelYear = "2019", DailyPrice = 90, Description  = "Araba 4 Açıklama" },
            new Car{ carId = 5, BrandId = 2, ColorId = 5, ModelYear = "2018", DailyPrice = 80, Description  = "Araba 5 Açıklama" },
            new Car{ carId = 6, BrandId = 3, ColorId = 1, ModelYear = "2017", DailyPrice = 70, Description  = "Araba 6 Açıklama" },
            new Car{ carId = 7, BrandId = 1, ColorId = 2, ModelYear = "2016", DailyPrice = 60, Description  = "Araba 7 Açıklama" },
            new Car{ carId = 8, BrandId = 2, ColorId = 3, ModelYear = "2015", DailyPrice = 50, Description  = "Araba 8 Açıklama" }
            };

        }
        public void Add(Car mycar)
        {
            cars.Add(mycar);
        }

        public void Delete(Car mycar)
        {
            Car carToDelete = null;
            carToDelete = cars.SingleOrDefault(c => c.carId == mycar.carId);
            if (carToDelete!=null)
            {
                cars.Remove(carToDelete);
            }
        }

        public List<Car> GetAll()
        {
            return cars;
        }


        public void Update(Car mycar)
        {
            Car carToUpdate = cars.SingleOrDefault(c=>c.carId == mycar.carId);
            if(carToUpdate != null)
            {
                carToUpdate.carId = mycar.carId;
                carToUpdate.ColorId = mycar.ColorId;
                carToUpdate.DailyPrice = mycar.DailyPrice;
                carToUpdate.Description = mycar.Description;
                carToUpdate.BrandId = mycar.BrandId;

            }
            else
            {
                Console.WriteLine("Not Found.");
            }
        }
    }
}
