using DropDownList.Models;

namespace DropDownList.Services
{
    public class LandRepository: ILandRepository
    {
        private List<Land> _lands;
        public List<Land> Lands { get { return _lands; } }

        public LandRepository()
        {
            _lands = new List<Land>();
            _lands.Add(new Land(landId: 0, name: "Все страны"));
            _lands.Add(new Land(landId: 1, name: "Россия"));
            _lands.Add(new Land(landId: 2, name: "Беларусь"));
            _lands.Add(new Land(landId: 3, name: "Германия"));
        }

        public int GetLandIdByName(string name)
        {
            var land = _lands.FirstOrDefault(land => land.Name == name);
            return land.LandId ?? 0;
        }
    }
}
