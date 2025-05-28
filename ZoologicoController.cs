using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using ZoologicoAPI.Model;

namespace ZoologicoAPI.Controller
{
    [ApiController]
    [Route("[controller]")]
    public class ZoologicoController : ControllerBase
    {
        private static List<Zoologico> zoologicos = new();

        [HttpGet]
        public List<Zoologico> GetAll() => zoologicos;

        [HttpGet("{id}")]
        public Zoologico GetById(int id) => zoologicos.ElementAtOrDefault(id);

        [HttpPost]
        public void Create(Zoologico zoo) => zoologicos.Add(zoo);

        [HttpPut("{id}")]
        public void Update(int id, Zoologico zoo) => zoologicos[id] = zoo;

        [HttpDelete("{id}")]
        public void Delete(int id) => zoologicos.RemoveAt(id);
    }
}