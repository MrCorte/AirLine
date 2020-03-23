using AirLine.Models;

namespace AirLine.Infrastructure.Interfaces
{
    public interface IPersonaRepository
    {
        Persona[] GetPersone();
        Persona GetPersonaById(int Id);
        bool PostPersona(Persona persona);
        bool DeletePersona(int idPersona);
        bool Update(Persona persona);
    }
}