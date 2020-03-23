using AirLine.ApplicationCore.Interfaces;
using AirLine.Models;
using Microsoft.AspNetCore.Mvc;

namespace AirLine.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PersonaController: ControllerBase
    {
        private IPersonaService personaService;
        public PersonaController(IPersonaService personaService)
        {
            this.personaService = personaService;
        }
        [HttpGet]
        public IActionResult GetPersone()
        {
            var persone = personaService.GetPersone();
            return Ok(persone);
        }
        [HttpGet("{Id}")]
        public IActionResult GetPersonaById(int Id)
        {
            var persona = personaService.GetPersonaById(Id);
            return Ok(persona);
        }
        
        [HttpPost]
        public IActionResult PostPersona(Persona persona)
        {
            var res = personaService.PostPersona(persona);
            return Ok(res);
        }
        
        [HttpDelete("{Id}")]
        public IActionResult DeletePersona(int idPersona)
        {
            var res = personaService.DeletePersona(idPersona);
            return Ok(res);
        }
        
        [HttpPost]
        public IActionResult Update(Persona persona)
        {
            var res = personaService.Update(persona);
            return Ok(res);
        }
    }
}