using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete
{
    public class InMemoryCarDal : ICarDal
    {

        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{Id=1, BrandId=1, ColorId=1, ModelYear=2012, DailyPrice=105000, Description="1.2 TDI"},
                new Car{Id=2, BrandId=1, ColorId=2, ModelYear=2001, DailyPrice=75000, Description="1.6 Benzin"},
                new Car{Id=3, BrandId=2, ColorId=3, ModelYear=2018, DailyPrice=405000, Description="1.4 TSI"},
                new Car{Id=4, BrandId=2, ColorId=2, ModelYear=1995, DailyPrice=40000, Description="1.6 Benzin/LPG"},
                new Car{Id=5, BrandId=3, ColorId=1, ModelYear=2020, DailyPrice=650000, Description="1.0 TSI"}
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = null;
            carToDelete = _cars.SingleOrDefault(c => c.ModelYear == car.ModelYear);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAllCar()
        {
            return _cars;
        }

        public List<Car> GetCarsByBrand(int BrandId)
        {
            return _cars.Where(c => c.BrandId == BrandId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = null;
            carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.Description = car.Description;
        }
    }
}
