using Business.Abstract;
using Core.DataAccess;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{

    public class CarManager : ICarService
    {
        ICarDal _carDal;
        public CarManager(ICarDal carDal)
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
            else
            {
                _carDal.Add(car);
            }
            
        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public Car GetById(int carId)
        {
            return _carDal.Get(c => c.Id == carId);
        }

        public List<CarDetailsDto> GetCarDetails()
        {
            return _carDal.GetCarDetails();
        }

        public List<Car> GetCarsByBrandId(int brandId)
        {
            return _carDal.GetAll(c => c.BrandId == brandId);
        }

        public List<Car> GetCarsByColorId(int colorId)
        {
            return _carDal.GetAll(c => c.ColorId == colorId);
        }

        public void Update(Car car)
        {
            _carDal.Update(car);
        }

        //public void Add(Car car)
        //{
        //    if (car == null)
        //        return;
        //    if (car.Description.Length < 2)
        //    {
        //        Console.WriteLine("Araba ismi minimum 2 karakter olmalıdır!");
        //    }

        //    if (car.DailyPrice <= 0)
        //    {
        //        Console.WriteLine("Araba günlük fiyatı 0'dan büyük olmalıdır.");
        //        return;
        //    }
        //    _carDal.Add(car);
        //}

        //public void Delete(Car car)
        //{
        //    throw new NotImplementedException();
        //}

        //public List<Car> Get(int id)
        //{
        //    return _carDal.GetAll(c => c.Id == id);
        //}

        //public List<Car> GetAll()
        //{
        //    return _carDal.GetAll();
        //}

        //public List<Car> GetCarsByBrandId(int brandId)
        //{
        //    throw new NotImplementedException();
        //}

        //public List<Car> GetCarsByColorId(int colorId)
        //{
        //    throw new NotImplementedException();
        //}

        //public void Update(Car car)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
