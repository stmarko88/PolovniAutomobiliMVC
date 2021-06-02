using Microsoft.AspNetCore.Mvc;
using PolovniAutomobiliMVC.Models;
using PolovniAutomobiliMVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PolovniAutomobiliMVC.Controllers
{
    public class CarController : Controller
    {
        private readonly ICarRepository carRepository;
        private readonly ICategoryRepository categoryRepository;

        public CarController(ICarRepository carRepository, ICategoryRepository categoryRepository)
        {
            this.carRepository = carRepository;
            this.categoryRepository = categoryRepository;
        }

        public ViewResult List()
        {
            CarListViewModel carListViewModel = new CarListViewModel()
            {
                Cars = carRepository.AllCars,
                CurrentCategory = "SUV"
            };

            return View(carListViewModel);
        }

        public IActionResult Details(int id)
        {
            var car = carRepository.GetCarById(id);
            if (car == null)
            {
                return NotFound();
            }
            return View(car);
        }
    }
}
