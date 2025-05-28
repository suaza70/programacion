using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using ZoologicoAPI.Model;

namespace ZoologicoAPI.Controller
{
    [ApiController]
    [Route("[controller]")]
    public class PersonaController : ControllerBase
    {
        private static List<Persona> personas = new();

        [HttpGet]
        public List<Persona> GetAll() => personas;

        [HttpGet("{id}")]
        public Persona GetById(int id) => personas.ElementAtOrDefault(id);

        [HttpPost]
        public void Create(Persona persona) => personas.Add(persona);

        [HttpPut("{id}")]
        public void Update(int id, Persona persona) => personas[id] = persona;

        [HttpDelete("{id}")]
        public void Delete(int id) => personas.RemoveAt(id);
    }
}