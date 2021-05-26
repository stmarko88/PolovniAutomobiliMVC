using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PolovniAutomobiliMVC.Models
{
    public interface ICarRepository
    {
        IEnumerable<Car> AllCars { get;}
        IEnumerable<Car> SpecialOfferCars { get; }
        Car GetCarById(int carId);
    }
}
