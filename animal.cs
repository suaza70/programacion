public class Animal
{
    private string nombre;
    private string especie;
    private string sexo;
    private float tamaño;
    private float peso;
    private int edad;
    private Habitat habitat;

    public Animal(string nombre, string especie, string sexo, float tamaño, 
                 float peso, int edad, Habitat habitat)
    {
        this.nombre = nombre;
        this.especie = especie;
        this.sexo = sexo;
        this.tamaño = tamaño;
        this.peso = peso;
        this.edad = edad;
        this.habitat = habitat;
    }

    // Propiedades (getters y setters)
    public string Nombre => nombre;
    public string Especie => especie;
    public Habitat Habitat => habitat;
    
}