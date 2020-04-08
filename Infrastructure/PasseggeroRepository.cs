using System.Linq;
using AirLine.Models;

namespace AirLine.Infrastructure.Interfaces
{
    public class PasseggeroRepository: IPasseggeroRepository

    {
    private AirLinesContext airLinesContext;

    public PasseggeroRepository(AirLinesContext airLinesContext)
    {
        this.airLinesContext = airLinesContext;
    }

    public Passeggero[] getPasseggeri()
    {
        var db = airLinesContext.Passeggero;
        Passeggero[] passeggeri;
        passeggeri = db.ToArray();
        return passeggeri;
    }

    public Passeggero getPasseggeroById(int Id)
    {
        var db = airLinesContext.Passeggero;
        var persona = db.Where(i => i.IdPersona == Id).First();
        return persona;
    }

    public bool Post(Passeggero passeggero)
    {
        var db = airLinesContext.Passeggero;
        db.Add(passeggero);
        return true;

    }

    public bool Delete(int Id)
    {
        var db = airLinesContext.Passeggero;
        var res = db.Where(i => i.Id == Id).First();
        db.Remove(res);
        return true;
    }

    public bool Update(Passeggero passeggero)
    {
        var db = airLinesContext;
        var pas = db.Passeggero.Where(i => i.Id == passeggero.Id).First();
        pas = passeggero;
        db.SaveChanges();
        return true;
    }
    }
}