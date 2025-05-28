using System.Collections.Generic;

namespace ZoologicoAPI.Model
{
    public class Habitat
    {
        public int Id { get; set; }
        public string Tipo { get; set; }
        public string Nombre { get; set; }
        public string Especie { get; set; }

        public List<Animal> Animales { get; set; } = new();

        public void AgregarAnimal(Animal animal) => Animales.Add(animal);
        public void EliminarAnimal(Animal animal) => Animales.Remove(animal);
        public List<Animal> ListarAnimales() => Animales;
    }
}