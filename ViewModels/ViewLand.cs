using DropDownList.Models;
using System.ComponentModel.DataAnnotations;

namespace DropDownList.ViewModels
{
    public class ViewLand
    {
		public int LandId { get; set; }

        [Display(Name = "Города")]
        public List<City> Cities { get; set; }
	}
}
