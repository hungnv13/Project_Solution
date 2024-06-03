using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_ClassLibrary.BussinessObject;

namespace Project_ClassLibrary.Repository
{
    public interface ICarRepository
    {
        IEnumerable<Car> GetCar();
        Car GetCarById(int carId);
        void InsearCar(Car car);
        void DeleteCar(int carId);
        void UpdateCar(Car car);
    }
}
