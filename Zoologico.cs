using System;
using System.Collections.Generic;

public class Zoologico
{
    public string Nombre { get; set; }
    public List<Animal> Animales { get; private set; }
    public List<PersonaTrabajo> Trabajadores { get; private set; }
    public List<Habitat> Habitats { get; private set; }

    // Constructor
    public Zoologico(string nombre)
    {
        Nombre = nombre;
        Animales = new List<Animal>();
        Trabajadores = new List<PersonaTrabajo>();
        Habitats = new List<Habitat>();
    }

    public void AgregarAnimal(Animal animal)
    {
        if (animal == null)
            throw new ArgumentNullException("El animal no puede ser nulo.");

        Animales.Add(animal);
    }

    public void EliminarAnimal(Animal animal)
    {
        Animales.Remove(animal);
    }

    public void AgregarHabitat(Habitat habitat)
    {
        if (habitat == null)
            throw new ArgumentNullException("El hábitat no puede ser nulo.");

        Habitats.Add(habitat);
    }

    public void EliminarHabitat(Habitat habitat)
    {
        Habitats.Remove(habitat);
    }

    public void ListarHabitats()
    {
        foreach (var habitat in Habitats)
        {
            Console.WriteLine($"- {habitat.Nombre} (Tipo: {habitat.Tipo})");
        }
    }
}
