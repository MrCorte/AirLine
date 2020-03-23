using System;
using System.Collections.Generic;

namespace AirLine.Models
{
    public partial class Persona
    {
        public Persona()
        {
            Passeggero = new HashSet<Passeggero>();
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public DateTime Nascita { get; set; }
        public bool Passaporto { get; set; }

        public virtual ICollection<Passeggero> Passeggero { get; set; }
    }
}
