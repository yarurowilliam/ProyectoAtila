using System;
using System.Collections.Generic;

namespace AtilaV1.Models
{
    public partial class Roles
    {
        public Roles()
        {
            Docentes = new HashSet<Docentes>();
        }

        public string IdRol { get; set; }
        public string NombreRol { get; set; }

        public virtual ICollection<Docentes> Docentes { get; set; }
    }
}
