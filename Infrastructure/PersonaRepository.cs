using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using AirLine.Infrastructure.Interfaces;
using AirLine.Models;

namespace AirLine.Infrastructure
{
    public class PersonaRepository : IPersonaRepository
    {
        private AirLinesContext airLinesContext;

        public PersonaRepository(AirLinesContext airLinesContext)
        {
            this.airLinesContext = airLinesContext;
        }

        public Persona[] GetPersone()
        {
            var db = airLinesContext.Persona;
            Persona[] persone;
            persone = db.ToArray();
            return persone;
        }

        public Persona GetPersonaById(int Id)
        {
            var db = airLinesContext.Persona;
            Persona persona = (Persona) db.Where(i => i.Id == Id).First();
            return persona;
        }

        public bool PostPersona(Persona persona)
        {
            var db = airLinesContext.Persona;
            db.Add(persona);
            return true;
        }

        public bool DeletePersona(int idPersona)
        {
            var db = airLinesContext;
            Persona persona = db.Persona.Where(i => i.Id == idPersona).First();
            db.Persona.Remove(persona);
            return true;
        }

        public bool Update(Persona persona)
        {
            var db = airLinesContext;
            var res = db.Persona.SingleOrDefault(i => i.Id == persona.Id);
            res = persona;
            db.SaveChanges();
            return true;
        }
    }
}