using AirLine.Models;

namespace AirLine.ApplicationCore.Interfaces
{
    public interface IPasseggeroService
    {
        Passeggero[] getPasseggeri();
        Passeggero[] getPasseggeriByVolo(int idVolo);
        Passeggero GetPasseggeroById(int Id);
        bool PostPasseggero(Passeggero passeggero);
        bool DeletePasseggero(int id);
        bool Update(Passeggero passeggero);
    }
}