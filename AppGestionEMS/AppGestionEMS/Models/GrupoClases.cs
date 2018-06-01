using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppGestionEMS.Models
{
    public class GrupoClases
    {
        public int Id { get; set;}
        public int asigDocenteId { get; set; }
        public virtual AsignacionDocentes asiGdocente { get; set;}
        public String aula { get; set; }
        public int maxAlum { get; set; }
        public int minAlum { get; set; }
    }
}