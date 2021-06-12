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
        private readonly ICarRepository _carRepository;
        private readonly ICategoryRepository _categoryRepository;

        public CarController(ICarRepository carRepository, ICategoryRepository categoryRepository)
        {
            _carRepository = carRepository;
            _categoryRepository = categoryRepository;
        }

        //public ViewResult List()
        //{
        //    CarListViewModel carListViewModel = new CarListViewModel()
        //    {
        //        Cars = carRepository.AllCars,
        //        CurrentCategory = "SUV"
        //    };

        //    return View(carListViewModel);
        //}

        public ViewResult List(int? categoryId)
        {
            CarListViewModel carListViewModel = new CarListViewModel()
            {
                Cars = _carRepository.AllCars,
                CurrentCategory = "All cars"
            };

            if (categoryId.HasValue)
            {
                carListViewModel.Cars = _carRepository.AllCars
                                                        .Where(c => categoryId.HasValue && c.CategoryId == categoryId);
                carListViewModel.CurrentCategory = _categoryRepository.AllCategories
                                                                        .Where(c => c.Id == categoryId.Value)
                                                                        .Select(c=> c.Name)
                                                                        .FirstOrDefault();
            }

            return View(carListViewModel);
        }

        public IActionResult Details(int id)
        {
            var car = _carRepository.GetCarById(id);
            if (car == null)
            {
                return NotFound();
            }
            return View(car);
        }
    }
}
