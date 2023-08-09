using DropDownList.Models;

namespace DropDownList.Services
{
    public interface ILandRepository
    {
        List<Land> Lands { get; }

        int GetLandIdByName(string name);
    }
}
