using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppGestionEMS.Models
{
    public class Matriculas
    {
        public int Id { get; set; }
        public int grupoClaseId { get; set; }
        public int cursoId { get; set; }
        public virtual GrupoClases grupoClase { get; set; }
        public virtual Cursos curso { get; set; }
        public String fechaMatricula { get; set; }
    }
}