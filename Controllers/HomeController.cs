using DropDownList.Models;
using DropDownList.Services;
using DropDownList.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DropDownList.Controllers
{
    public class HomeController : Controller
    {
        ILandRepository _landsRepository;
        ICityRepository _citiesRepository;

        public IActionResult Index(int landId = 0)
        {
            ViewLand viewLand;
            List<Land> lands  = _landsRepository.Lands;
            List<City> cities = _citiesRepository.GetAll();

            ViewBag.Lands = new SelectList(lands.OrderBy(land => land.LandId), "LandId", "Name");

            List<City> filteredCities = new List<City>();

            if (landId != 0)
            {
                filteredCities = cities.Where(city => city.LandId == landId).ToList();
                viewLand = new ViewLand() { LandId = landId, Cities = filteredCities };
            }
            else
            {
                viewLand = new ViewLand() { LandId = landId, Cities = cities };
            }

            return View(viewLand);
        }

        [HttpPost]
        public IActionResult Select(string country)
        {
            List<Land> lands = _landsRepository.Lands;
            return RedirectToAction("Index", "Home", new { landId = country });
        }

        public HomeController()
        {
            _landsRepository = new LandRepository();
            _citiesRepository = new CityRepository(_landsRepository);
        }
    }
}