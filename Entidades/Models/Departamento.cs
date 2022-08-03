using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entidades.Models
{
    public class Departamento
    {
        [Key]
        public int DepartamentoId { get; set; }
        public string NombreDepartamento { get; set; }

        public IEnumerable<Empleados> Empleados { get; set; }
    }
}
