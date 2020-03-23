using AirLine.Models;

namespace AirLine.ApplicationCore.Interfaces
{
    public interface IPersonaService
    {
        Persona[] GetPersone();
        Persona GetPersonaById(int Id);
        bool PostPersona(Persona persona);
        bool DeletePersona(int idPersona);
        bool Update(Persona persona);
    }
}