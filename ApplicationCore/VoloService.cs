using System.Runtime.InteropServices;
using AirLine.ApplicationCore.Interfaces;
using AirLine.Infrastructure.Interfaces;
using AirLine.Models;

namespace AirLine.ApplicationCore
{
    public class VoloService : IVoloService
    {
        private IVoloRepository voloRepository;

        public VoloService(IVoloRepository voloRepository)
        {
            this.voloRepository = voloRepository;
        }

        public Volo[] GetVoli()
        {
            var voli = voloRepository.GetVoli();
            return voli;
        }

        public Volo GetVoloById(int Id)
        {
            var volo = voloRepository.GetVoloById(Id);
            return volo;
        }

        public bool Post(Volo volo)
        {
            var res = voloRepository.Post(volo);
            if (volo != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Delete(int idVolo)
        {
            var res = voloRepository.Delete(idVolo);
            return res;
        }

        public bool Update(Volo volo)
        {
            var res = voloRepository.Update(volo);
            if (volo != null)
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