using AirLine.Models;

namespace AirLine.Infrastructure.Interfaces
{
    public interface IVoloRepository
    {
        Volo[] GetVoli();
        Volo GetVoloById(int Id);
        bool Post(Volo volo);
        bool Delete(int idVolo);
        bool Update(Volo volo);
    }
}