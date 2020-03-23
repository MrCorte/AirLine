using System;
using System.Collections.Generic;

namespace AirLine.Models
{
    public partial class Passeggero
    {
        public int Id { get; set; }
        public int IdPersona { get; set; }
        public int IdVolo { get; set; }
        public bool ValigiaExtra { get; set; }

        public virtual Persona IdPersonaNavigation { get; set; }
        public virtual Volo IdVoloNavigation { get; set; }
    }
}
