using System;
using System.Collections.Generic;

public class Persona
{
    private string nombre;
    private string cedula;
    private string email;
    private int edad;

    public static List<Persona> PersonasRegistradas = new List<Persona>();

    public string Nombre
    {
        get { return nombre; }
        set { nombre = value; }
    }

    public string Cedula
    {
        get { return cedula; }
        set { cedula = value; }
    }

    public string Email
    {
        get { return email; }
        set { email = value; }
    }

    public int Edad
    {
        get { return edad; }
        set { edad = value; }
    }

    public Persona(string nombre, string cedula, string email, int edad)
    {
        this.nombre = nombre;
        this.cedula = cedula;
        this.email = email;
        this.edad = edad;
    }

    public void RegistrarPersona()
    {
        PersonasRegistradas.Add(this);
        Console.WriteLine("Persona registrada correctamente.");
    }

    public void EliminarPersona()
    {
        if (PersonasRegistradas.Contains(this))
        {
            PersonasRegistradas.Remove(this);
            Console.WriteLine("Persona eliminada del sistema.");
        }
        else
        {
            Console.WriteLine("La persona no se encuentra registrada.");
        }
    }

    public virtual void ConsultarPersona()
    {
        Console.WriteLine("Nombre: " + Nombre);
        Console.WriteLine("Cédula: " + Cedula);
        Console.WriteLine("Email: " + Email);
        Console.WriteLine("Edad: " + Edad);
    }
}