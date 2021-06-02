using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PolovniAutomobiliMVC.Models
{
    public class CarRepository : ICarRepository
    {
        private readonly AppDbContext _appDbContext;

        public CarRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Car> AllCars
        {
            get { return _appDbContext.Cars.Include(c => c.Category); }
        }

        public IEnumerable<Car> SpecialOfferCars
        {
            get { return _appDbContext.Cars.Include(c => c.Category).Include(f => f.FuelType).Where(s => s.IsSpecialOffer); }
        }

        public Car GetCarById(int carId)
        {
            return _appDbContext.Cars.FirstOrDefault(c => c.Id == carId);
        }
    }
}
