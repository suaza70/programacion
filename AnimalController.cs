using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using ZoologicoAPI.Model;

namespace ZoologicoAPI.Controller
{
    [ApiController]
    [Route("[controller]")]
    public class AnimalController : ControllerBase
    {
        private static List<Animal> animales = new();

        [HttpGet]
        public List<Animal> GetAll() => animales;

        [HttpGet("{id}")]
        public Animal GetById(int id) => animales.ElementAtOrDefault(id);

        [HttpPost]
        public void Create(Animal animal) => animales.Add(animal);

        [HttpPut("{id}")]
        public void Update(int id, Animal animal) => animales[id] = animal;

        [HttpDelete("{id}")]
        public void Delete(int id) => animales.RemoveAt(id);
    }
}