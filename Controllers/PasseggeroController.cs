using AirLine.ApplicationCore.Interfaces;
using AirLine.Models;
using Microsoft.AspNetCore.Mvc;

namespace AirLine.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PasseggeroController : ControllerBase
    {
        private IPasseggeroService passeggeroService;

        public PasseggeroController(IPasseggeroService passeggeroService)
        {
            this.passeggeroService = passeggeroService;
        }
        [HttpGet]
        public IActionResult GetPasseggeri()
        {
            var passeggeri = passeggeroService.getPasseggeri();
            return Ok(passeggeri);
        }
        [HttpGet("{Id}")]
        public IActionResult GetPasseggeroById(int Id)
        {
            var passeggero = passeggeroService.GetPasseggeroById(Id);
            return Ok(passeggero);
        }

        [HttpGet("{Id}")]
        public IActionResult GetPasseggeriByVolo(int id)
        {
            var passeggeri = passeggeroService.getPasseggeriByVolo(id);
            return Ok(passeggeri);
        }
        
        [HttpPost]
        public IActionResult PostPersona(Passeggero passeggero)
        {
            var res = passeggeroService.PostPasseggero(passeggero);
            return Ok(res);
        }
        
        [HttpDelete("{Id}")]
        public IActionResult DeletePersona(int id)
        {
            var res = passeggeroService.DeletePasseggero(id);
            return Ok(res);
        }
        
        [HttpPost]
        public IActionResult Update(Passeggero passeggero)
        {
            var res = passeggeroService.Update(passeggero);
            return Ok(res);
        }
    }
}