public class Habitat
{
    private int id;
    private string tipo;
    private string nombre;
    private string especie;

    public Habitat(int id, string tipo, string nombre, string especie)
    {
        this.id = id;
        this.tipo = tipo;
        this.nombre = nombre;
        this.especie = especie;
    }

    public int Id
    {
        get{return this.id;}
    }

    public string Tipo
    {
        get{return this.tipo;}
    }

    public string Nombre
    {
        get{return this.nombre;}
    }

    public string Especie
    {
        get{return this.especie;}
    }
}