using AirLine.Models;

namespace AirLine.Infrastructure.Interfaces
{
    public interface IPasseggeroRepository
    {
        Passeggero[] getPasseggeri();
        Passeggero getPasseggeroById(int Id);
        Passeggero[] getPasseggeroByVolo(int id);
        bool Post(Passeggero passeggero);
        bool Delete(int Id);
        bool Update(Passeggero passeggero);
    }
}