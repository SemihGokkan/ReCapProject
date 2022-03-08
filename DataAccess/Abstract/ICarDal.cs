using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ICarDal
    {
        List<Car> GetAllCar();
        void Add(Car car);
        void Update(Car car);
        void Delete(Car car);

        List<Car> GetCarsByBrand(int BrandId);
    }
}
