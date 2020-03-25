using AirLine.ApplicationCore.Interfaces;
using AirLine.Models;
using Microsoft.AspNetCore.Mvc;

namespace AirLine.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class VoloController : ControllerBase
    {
        private IVoloService voloservice;

        public VoloController(IVoloService voloservice)
        {
            this.voloservice = voloservice;
        }
        public IActionResult GetVoli()
        {
            var voli = voloservice.GetVoli();
            return Ok(voli);
        }
        [HttpGet("{Id}")]
        public IActionResult GetPersonaById(int Id)
        {
            var volo = voloservice.GetVoloById(Id);
            return Ok(volo);
        }
        
        [HttpPost]
        public IActionResult Post(Volo volo)
        {
            var res = voloservice.Post(volo);
            return Ok(res);
        }
        
        [HttpDelete("{Id}")]
        public IActionResult Delete(int IdVolo)
        {
            var res = voloservice.Delete(IdVolo);
            return Ok(res);
        }
        
        [HttpPost]
        public IActionResult Update(Volo volo)
        {
            var res = voloservice.Update(volo);
            return Ok(res);
        }
    }
}