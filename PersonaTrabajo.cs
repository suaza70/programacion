using System;

public class PersonaTrabajo : Persona
{
    private string cargo;
    private string area;
    private string horarioAsignado;

    public string Cargo
    {
        get { return cargo; }
        set { cargo = value; }
    }

    public string Area
    {
        get { return area; }
        set { area = value; }
    }

    public PersonaTrabajo(string nombre, string cedula, string email, int edad, string cargo, string area)
        : base(nombre, cedula, email, edad)
    {
        this.cargo = cargo;
        this.area = area;
    }

    public void AsignarHorario()
    {
        horarioAsignado = "Lunes a Viernes de 8am a 5pm";
        Console.WriteLine("Horario asignado: " + horarioAsignado);
    }

    public void ConsultarEmpleado()
    {
        Console.WriteLine("Empleado: " + Nombre);
        Console.WriteLine("Cargo: " + Cargo);
        Console.WriteLine("Área: " + Area);
        Console.WriteLine("Horario: " + (horarioAsignado ?? "No asignado"));
    }

    public override void ConsultarPersona()
    {
        base.ConsultarPersona();
        Console.WriteLine("Cargo: " + Cargo);
        Console.WriteLine("Área: " + Area);
    }
}