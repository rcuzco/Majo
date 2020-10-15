using System;

namespace MajoCore.Model
{
    public class Persona
    {
        public int Id { get; set; }
        public string Nombres { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public int TipoDocumentoIdentidad { get; set; }
        public string DocumentoIdentidad { get; set; }
        public string Sexo { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string CorreoElectronico { get; set; }
        public string TelefonoFijo { get; set; }
        public string TelefonoMovil { get; set; }
    }
}