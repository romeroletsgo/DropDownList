namespace DropDownList.Models
{
    public class City
    {
		public string CityId { get; set; }
        public string? Name { get; set; }
		public int LandId { get; set; } 
		public int PopulationSize { get; set; } 

		public City(string name, int landId, int populationSize)
		{
			CityId = Guid.NewGuid().ToString();
			Name = name;
			LandId = landId;
			PopulationSize = populationSize;
		}
	}
}
