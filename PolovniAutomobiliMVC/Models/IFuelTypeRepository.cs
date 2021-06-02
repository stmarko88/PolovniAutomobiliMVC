using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PolovniAutomobiliMVC.Models
{
    public interface IFuelTypeRepository
    {
        IEnumerable<FuelType> AllFuelTypes { get; }
    }
}
