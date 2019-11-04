using Newtonsoft.Json;

namespace AtilaV1.Models
{
    public partial class Asignaturas
    {
        [JsonProperty("idAsignatura")]
        public string IdAsignatura { get; set; }
        [JsonProperty("nombreAsignatura")]
        public string NombreAsignatura { get; set; }
    }
}
