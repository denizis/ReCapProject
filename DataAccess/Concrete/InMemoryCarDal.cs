using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;






        public InMemoryCarDal()
        {

            _cars = new List<Car> {
          new Car { CarId=1,BrandId=2,ColorId=3,DailyPrice=25000,ModelYear=2024,Description="2024 model kırmızı renki Volkswagen Marka araba"},
          new Car { CarId=1,BrandId=1,ColorId=1,DailyPrice=35000,ModelYear=2024,Description="2024 model Beyaz renki Volkswagen Marka araba"},
          new Car { CarId=4,BrandId=1,ColorId=2,DailyPrice=28000,ModelYear=2020,Description="2020 model Siyah renki Mercedes Marka araba"},
          new Car { CarId=3,BrandId=7,ColorId=6,DailyPrice=20000,ModelYear=2018,Description="2018 model Beyaz renki Renault Marka araba"},


        };




        }






        public void Add(Car car)
        {
            _cars.Add(car);
            Console.WriteLine("Eklendi CarId:" + car.CarId);
        }

        public void Delete(Car car)
        {
            Car CarToDelet = _cars.SingleOrDefault(p => p.CarId == car.CarId);

            _cars.Remove(CarToDelet);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAllByModel(int CarId)
        {
            return _cars.Where(p => p.CarId == CarId).ToList();
        }

        public void Update(Car car)
        {
            Car CarToUJpdate = _cars.SingleOrDefault(p => p.CarId == car.CarId);

            CarToUJpdate.CarId = car.CarId;
            CarToUJpdate.BrandId = car.BrandId;
            CarToUJpdate.ColorId = car.ColorId;
            CarToUJpdate.DailyPrice = car.DailyPrice;
            CarToUJpdate.ModelYear = car.ModelYear;
            CarToUJpdate.Description = car.Description;

        }
        }
    }
