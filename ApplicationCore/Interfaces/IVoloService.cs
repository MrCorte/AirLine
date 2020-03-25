using AirLine.Models;

namespace AirLine.ApplicationCore.Interfaces
{
    public interface IVoloService
    {
        Volo[] GetVoli();
        Volo GetVoloById(int Id);
        bool Post(Volo volo);
        bool Delete(int idVolo);
        bool Update(Volo volo);
    }
}