using DropDownList.Models;

namespace DropDownList.Services
{
    public class CityRepository: ICityRepository
    {
        private List<City> _cities;
        public CityRepository(ILandRepository landRepository) {
            
            int idRussiaLand  = landRepository.GetLandIdByName("Россия");
            int idBelarusLand = landRepository.GetLandIdByName("Беларусь");
            int idGermanyLand = landRepository.GetLandIdByName("Германия");

            _cities = new List<City>()
            {
                new City(name: "Москва",          landId: idRussiaLand, populationSize: 11920000),
                new City(name: "Санкт-Петербург", landId: idRussiaLand, populationSize: 6000000),
                new City(name: "Новосибирск",     landId: idRussiaLand, populationSize: 1650000),

                new City(name: "Минск",           landId: idBelarusLand, populationSize: 2000000),
                new City(name: "Гомель",          landId: idBelarusLand, populationSize: 507000),
                new City(name: "Гродно",          landId: idBelarusLand, populationSize: 366000),

                new City(name: "Берлин",          landId: idGermanyLand, populationSize: 3700000),
                new City(name: "Гамбург",         landId: idGermanyLand, populationSize: 1800000),
                new City(name: "Мюнхен",          landId: idGermanyLand, populationSize: 1500000)
            };
        }

        public List<City> GetAll()
        {
            return _cities;
        }
    }
}
