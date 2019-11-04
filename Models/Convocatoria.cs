using System;
using Newtonsoft.Json;

namespace AtilaV1.Models
{
    public partial class Convocatoria
    {
        [JsonProperty("IdConvocatoria")]
        public string IdConvocatoria { get; set; }
        [JsonProperty("fechaInicial")]
        public DateTime? FechaInicial { get; set; }
        [JsonProperty("fechaFinal")]
        public DateTime? FechaFinal { get; set; }
    }
}
