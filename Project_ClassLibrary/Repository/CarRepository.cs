using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_ClassLibrary.BussinessObject;
using Project_ClassLibrary.DataAccess;

namespace Project_ClassLibrary.Repository
{
    public class CarRepository : ICarRepository
    {
        public Car GetCarById(int carId) => CarDBContext.Instance.GetCarByID(carId);
        public IEnumerable<Car> GetCar() => CarDBContext.Instance.GetCarList;
        public void InsearCar(Car car) => CarDBContext.Instance.AddNew(car);
        public void DeleteCar(int carId) => CarDBContext.Instance.Remove(carId);
        public void UpdateCar(Car car) => CarDBContext.Instance.Update(car);

    }
}
