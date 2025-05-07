using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== SISTEMA DE GESTIÓN DEL ZOOLÓGICO ===");
        
        // Crear el zoológico
        Zoologico zoo = new Zoologico("Zootopía");
        Console.WriteLine($"\nBienvenido a {zoo.Nombre}\n");

        // Crear 5 hábitats
        var habitatSelva = new Habitat(1, "Tropical", "Selva", "Mamíferos y aves");
        var habitatDesierto = new Habitat(2, "Árido", "Desierto", "Reptiles");
        var habitatPolar = new Habitat(3, "Polar", "Ártico", "Animales polares");
        var habitatAcuatico = new Habitat(4, "Acuático", "Océano", "Peces y mamíferos acuáticos");
        var habitatSabana = new Habitat(5, "Sabana", "Pradera", "Grandes mamíferos");

        // Agregar hábitats al zoológico
        zoo.AgregarHabitat(habitatSelva);
        zoo.AgregarHabitat(habitatDesierto);
        zoo.AgregarHabitat(habitatPolar);
        zoo.AgregarHabitat(habitatAcuatico);
        zoo.AgregarHabitat(habitatSabana);

        // Crear 5 animales
        var leon = new Animal("Simba", "León", "Macho", 1.8f, 190f, 5, habitatSabana);
        var canguro = new Animal("Saltarín", "Canguro", "Hembra", 1.5f, 85f, 3, habitatDesierto);
        var pinguino = new Animal("Pingu", "Pingüino", "Macho", 1.2f, 35f, 4, habitatPolar);
        var delfin = new Animal("Flipper", "Delfín", "Hembra", 2.5f, 200f, 8, habitatAcuatico);
        var tucan = new Animal("Pico", "Tucán", "Macho", 0.6f, 0.8f, 2, habitatSelva);

        // Agregar animales al zoológico
        zoo.AgregarAnimal(leon);
        zoo.AgregarAnimal(canguro);
        zoo.AgregarAnimal(pinguino);
        zoo.AgregarAnimal(delfin);
        zoo.AgregarAnimal(tucan);

        // Mostrar información del zoológico
        Console.WriteLine("\n=== HÁBITATS DISPONIBLES ===");
        zoo.ListarHabitats();

        Console.WriteLine("\n=== ANIMALES DEL ZOOLÓGICO ===");
        Console.WriteLine($"Total de animales: {zoo.Animales.Count}");
        foreach (var animal in zoo.Animales)
        {
            Console.WriteLine($"- {animal.Nombre} ({animal.Especie}) en {animal.Habitat.Nombre}");
        }

        // Crear 5 empleados con horarios específicos
        var empleados = new List<PersonaTrabajo>
        {
            new PersonaTrabajo("Carlos Méndez", "V001", "carlos@zoo.com", 35, "Veterinario Jefe", "Salud Animal"),
            new PersonaTrabajo("Laura Gómez", "V002", "laura@zoo.com", 28, "Veterinaria", "Salud Animal"),
            new PersonaTrabajo("Pedro Rojas", "C001", "pedro@zoo.com", 42, "Cuidador Senior", "Mamíferos"),
            new PersonaTrabajo("Ana Torres", "C002", "ana@zoo.com", 31, "Cuidadora", "Aves"),
            new PersonaTrabajo("Mario Silva", "A001", "mario@zoo.com", 38, "Administrador", "Dirección")
        };

        // Asignar horarios personalizados a cada empleado
        empleados[0].AsignarHorario("Lunes a Viernes: 7:00 AM - 3:00 PM (Turno mañana)");
        empleados[1].AsignarHorario("Lunes a Viernes: 3:00 PM - 11:00 PM (Turno Tarde)");
        empleados[2].AsignarHorario("Martes a Sábado: 6:00 AM - 2:00 PM");
        empleados[3].AsignarHorario("Miércoles a Domingo: 2:00 PM - 10:00 PM");
        empleados[4].AsignarHorario("Lunes a Viernes: 9:00 AM - 5:00 PM (Horario administrativo)");

        // Registrar empleados
        Console.WriteLine("\n=== REGISTRO DE EMPLEADOS ===");
        foreach (var empleado in empleados)
        {
            empleado.RegistrarPersona();
        }

        // Mostrar información completa de empleados con horarios
        Console.WriteLine("\n=== INFORMACIÓN COMPLETA DE EMPLEADOS ===");
        foreach (var empleado in empleados)
        {
            empleado.ConsultarEmpleado();
            Console.WriteLine("-----------------------------");
        }

        // Operaciones de ejemplo
        Console.WriteLine("\n=== OPERACIONES DEL DÍA ===");
        zoo.EliminarAnimal(canguro);
        Console.WriteLine($"Se eliminó a {canguro.Nombre} del zoológico.");

        // Mostrar resumen final
        Console.WriteLine("\n=== RESUMEN FINAL ===");
        Console.WriteLine($"Total de animales: {zoo.Animales.Count}");
        Console.WriteLine($"Total de hábitats: {zoo.Habitats.Count}");
        Console.WriteLine($"Total de empleados: {Persona.PersonasRegistradas.Count}");

        Console.WriteLine("\n=== HORARIOS DE TRABAJO ===");
        foreach (var empleado in empleados)
        {
            empleado.ConsultarEmpleado();
        }
    }
}