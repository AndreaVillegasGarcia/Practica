using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AppGestionEMS.Models
{
    public class AsignacionDocentes
    {
        public int Id { get; set; }
        [Display (Name = "Cursos")]
        public int CursoId { get; set;  }
        public virtual Cursos curso { get; set; }
        public int CreditosAsignados { get; set; }
    }
}