using System.Collections.Generic;

namespace ZoologicoAPI.Model
{
    public class Zoologico
    {
        public string Nombre { get; set; }
        public List<Animal> Animales { get; set; } = new();
        public List<Persona> Personas { get; set; } = new();

        public void AgregarPersona(Persona persona) => Personas.Add(persona);
        public void AgregarHabitat(Habitat habitat) { }
        public void EliminarHabitat(Habitat habitat) { }
    }
}