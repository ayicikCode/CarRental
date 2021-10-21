using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMEmory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> { 
                new Car {ProductId=1,CategoryId=1, ProductName="Mercedes",UnitPrice=4800,UnitsInStock=7,Details="Mercedes E220 cdi siyah(haftalık kiralama fiyatıdır)" },
                new Car {ProductId=2,CategoryId=2, ProductName="Volvo",UnitPrice=4500,UnitsInStock=5,Details="" },
                new Car {ProductId=3,CategoryId=3, ProductName="Audi",UnitPrice=5000,UnitsInStock=4,Details="Audi A6 Benzinli Otomatik" },
                new Car {ProductId=4,CategoryId=4, ProductName="Toyota",UnitPrice=3000,UnitsInStock=10,Details="Toyota Corolla 1.6 CDI" },
                new Car {ProductId=5,CategoryId=5, ProductName="Volswagen",UnitPrice=4200,UnitsInStock=8,Details="Otomatik 1.6 Benzinli" },
                new Car {ProductId=6,CategoryId=6, ProductName="Renault",UnitPrice=3000,UnitsInStock=10,Details="Dizel Otomatik ve Manuel seçenğimiz mevcuttur..." },
                new Car {ProductId=7,CategoryId=7, ProductName="Skoda",UnitPrice=4000,UnitsInStock=6,Details="SuperB 2.0 Otomatik" }
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            //foreach (var c in _cars)
            //{
            //  if (car.ProductId == c.ProductId)
            //{
            //           carToDelete = c;
            //   }
            //}
            Car carToDelete = _cars.SingleOrDefault(c => c.ProductId == car.ProductId);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAllbyCategory(int categoryId)
        {
            return _cars.Where(c => c.CategoryId == categoryId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.ProductId == car.ProductId);
            carToUpdate.ProductName = car.ProductName;
            carToUpdate.UnitPrice = car.UnitPrice;
            carToUpdate.CategoryId = car.CategoryId;
            carToUpdate.Details = car.Details;
            carToUpdate.UnitsInStock = car.UnitsInStock;
        }
    }
}
