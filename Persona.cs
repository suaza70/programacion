using System.Collections.Generic;

namespace ZoologicoAPI.Model
{
    public class Persona
    {
        public string Nombre { get; set; }
        public string Cedula { get; set; }
        public string Email { get; set; }
        public int Edad { get; set; }

        public void RegistrarPersona() { }
        public void ConsultarPersona() { }
        public void ActualizarPersona() { }
    }
}