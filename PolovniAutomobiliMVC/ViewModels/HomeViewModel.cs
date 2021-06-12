using PolovniAutomobiliMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PolovniAutomobiliMVC.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Car> SpecialOffers { get; set; }
    }
}
