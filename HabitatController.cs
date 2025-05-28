using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using ZoologicoAPI.Model;

namespace ZoologicoAPI.Controller
{
    [ApiController]
    [Route("[controller]")]
    public class HabitatController : ControllerBase
    {
        private static List<Habitat> habitats = new();

        [HttpGet]
        public List<Habitat> GetAll() => habitats;

        [HttpGet("{id}")]
        public Habitat GetById(int id) => habitats.ElementAtOrDefault(id);

        [HttpPost]
        public void Create(Habitat habitat) => habitats.Add(habitat);

        [HttpPut("{id}")]
        public void Update(int id, Habitat habitat) => habitats[id] = habitat;

        [HttpDelete("{id}")]
        public void Delete(int id) => habitats.RemoveAt(id);
    }
}