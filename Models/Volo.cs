using System;
using System.Collections.Generic;

namespace AirLine.Models
{
    public partial class Volo
    {
        public Volo()
        {
            Passeggero = new HashSet<Passeggero>();
        }

        public int Id { get; set; }
        public string LuogoPartenza { get; set; }
        public string LuogoArrivo { get; set; }
        public DateTime DataPartenza { get; set; }
        public DateTime DataArrivo { get; set; }
        public int PostiDisponibili { get; set; }

        public virtual ICollection<Passeggero> Passeggero { get; set; }
    }
}
