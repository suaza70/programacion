namespace ZoologicoAPI.Model
{
    public class PersonaAdministrativo : Persona
    {
        public string Cargo { get; set; }
        public string Area { get; set; }

        public void AsignarHorario() { }
        public void ConsultarEmpleado() { }
    }
}