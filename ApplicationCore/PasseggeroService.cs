using AirLine.ApplicationCore.Interfaces;
using AirLine.Infrastructure.Interfaces;
using AirLine.Models;

namespace AirLine.ApplicationCore
{
    public class PasseggeroService : IPasseggeroService
    {
        private IPasseggeroRepository passeggeroRepository;

        public PasseggeroService(IPasseggeroRepository passeggeroRepository)
        {
            this.passeggeroRepository = passeggeroRepository;
        }

        public Passeggero[] getPasseggeri()
        {
            var passeggeri = passeggeroRepository.getPasseggeri();
            return passeggeri;
        }

        public Passeggero[] getPasseggeriByVolo(int idVolo)
        {
            var passeggeri = passeggeroRepository.getPasseggeroByVolo(idVolo);
            return passeggeri;
        }

        public Passeggero GetPasseggeroById(int Id)
        {
            var passeggero = passeggeroRepository.getPasseggeroById(Id);
            if (passeggero != null)
            {
                return passeggero;
            }
            else
            {
                return null;
            }
        }

        public bool PostPasseggero(Passeggero passeggero)
        {
            var res = passeggeroRepository.Post(passeggero);
            if (passeggero != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool DeletePasseggero(int id)
        {
            var res = passeggeroRepository.Delete(id);
            return res;
        }
        public bool Update(Passeggero passeggero)
        {
            var res = passeggeroRepository.Update(passeggero);
            if (passeggero != null)
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