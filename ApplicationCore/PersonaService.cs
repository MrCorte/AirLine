using AirLine.ApplicationCore.Interfaces;
using AirLine.Infrastructure;
using AirLine.Infrastructure.Interfaces;
using AirLine.Models;

namespace AirLine.ApplicationCore
{
    public class PersonaService : IPersonaService
    {
        private IPersonaRepository personaRepository;

        public PersonaService(IPersonaRepository personaRepository)
        {
            this.personaRepository = personaRepository;
        }

        public Persona[] GetPersone()
        {
            var persone = personaRepository.GetPersone();
            return persone;
        }

        public Persona GetPersonaById(int Id)
        {
            var persona = personaRepository.GetPersonaById(Id);
            if (persona != null)
            {
                return persona;
            }
            else
            {
                return null;
            }
                
        }

        public bool PostPersona(Persona persona)
        {
            var res = personaRepository.PostPersona(persona);
            if (persona != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool DeletePersona(int idPersona)
        {
            var res = personaRepository.DeletePersona(idPersona);
            return res;
        }

        public bool Update(Persona persona)
        {
            var res = personaRepository.Update(persona);
            if (persona != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}