using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace AtilaV1.Models
{
    public partial class Docentes
    {
        [JsonProperty("idDocente")]
        public string IdDocente { get; set; }
        [JsonProperty("primerApellido")]
        public string PrimerApellido { get; set; }
        [JsonProperty("segundoApellido")]
        public string SegundoApellido { get; set; }
        [JsonProperty("primerNombre")]
        public string PrimerNombre { get; set; }
        [JsonProperty("segundoNombre")]
        public string SegundoNombre { get; set; }
        [JsonProperty("idRol")]
        public string IdRol { get; set; }
        [JsonProperty("telefono")]
        public string Telefono { get; set; }
        [JsonProperty("correo")]
        public string Correo { get; set; }
        [JsonProperty("fechaNacimiento")]
        public DateTime? FechaNacimiento { get; set; }
        [JsonProperty("contraseña")]
        public string Contraseña { get; set; }

        public virtual Roles IdRolNavigation { get; set; }
    }
}
