using Entidades.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Datos.Conexion
{
    public class ApplicationDBContext:DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options ):base(options)
        {

        }

        public DbSet<Empleados> Empleado { get; set; }
        public DbSet<Departamento>  Departamento { get; set; }
    }
}
