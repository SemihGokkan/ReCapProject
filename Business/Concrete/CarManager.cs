using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        IEntityRepository<Car> _carDal;
        public CarManager(IEntityRepository<Car> carDal)
        {
            _carDal = carDal;
        }

        public void Add(Car car)
        {
            if (car == null)
                return;
            if (car.Description.Length < 2)
            {
                Console.WriteLine("Araba ismi minimum 2 karakter olmalıdır!");
            }
            
            if (car.DailyPrice <= 0)
            {
                Console.WriteLine("Araba günlük fiyatı 0'dan büyük olmalıdır.");
                return;
            }
            _carDal.Add(car);
        }
        public List<Car> Get(int id)
        {
            return _carDal.GetAll(c => c.Id == id);
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }
    }
}
