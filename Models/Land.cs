namespace DropDownList.Models
{
	public class Land
	{
		public int? LandId { get; set; } 
		public string? Name { get; set; }

		public Land(int landId, string name)
		{
			LandId = landId;
			Name = name;
		}
	}
}
