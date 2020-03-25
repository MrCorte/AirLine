using System.Linq;
using AirLine.Infrastructure.Interfaces;
using AirLine.Models;

namespace AirLine.Infrastructure
{
    public class VoloRepository: IVoloRepository
    {
        private AirLinesContext airLinesContext;

        public VoloRepository(AirLinesContext airLinesContext)
        {
            this.airLinesContext = airLinesContext;
        }

        public Volo[] GetVoli()
        {
            var db = airLinesContext.Volo;
            Volo[] voli;
            voli = db.ToArray();
            return voli;
        }

        public Volo GetVoloById(int Id)
        {
            var db = airLinesContext.Volo;
            Volo volo = db.Where(i => i.Id == Id).First();
            return volo;
        }
        public bool Post(Volo  volo)
        {
            var db = airLinesContext.Volo;
            db.Add(volo);
            return true;
        }
        
        public bool Delete(int idVolo)
        {
            var db = airLinesContext.Volo;
            Volo volo = db.Where(i => i.Id == idVolo).First();
            db.Remove(volo);
            return true;
        }
        
        public bool Update(Volo volo)
        {
            var db = airLinesContext;
            var res = db.Volo.SingleOrDefault(i => i.Id == volo.Id);
            res = volo;
            db.SaveChanges();
            return true;
        }

    }
}