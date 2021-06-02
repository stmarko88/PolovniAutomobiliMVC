using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PolovniAutomobiliMVC.Models
{
    public class FuelTypeRepository : IFuelTypeRepository
    {
        private readonly AppDbContext appDbContext;

        public FuelTypeRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public IEnumerable<FuelType> AllFuelTypes
        {
            get { return appDbContext.FuelTypes; }
        }
    }
}
