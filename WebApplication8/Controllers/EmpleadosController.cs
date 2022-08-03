using Entidades.Models;
using Microsoft.AspNetCore.Mvc;
using Servicio.Interfaces;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication8.Controllers
{
    public class EmpleadosController : Controller
    {
        IBaseRepository<Empleados> _EmpleadoRepository;
        IBaseRepository<Departamento> _DepartamentoRepository;

        public EmpleadosController(IBaseRepository<Empleados> EmpleadoRepository, IBaseRepository<Departamento> departamentoRepository)
        {
            _EmpleadoRepository = EmpleadoRepository;
            _DepartamentoRepository = departamentoRepository;
        }

        public async Task<IActionResult> Index()
        {
            

            return View();
        }

      

        public async Task<IActionResult> GetData()
        {
            var listaemp= await _EmpleadoRepository.GetAll();
            var listade=await _DepartamentoRepository.GetAll();

            var lista =   from emp in listaemp
                        join departamento in listade on emp.DepartamentoId equals departamento.DepartamentoId
                        select new { emp.EmpleadoId,emp.Nombres,emp.Apellidos,emp.Direccion,emp.Email,emp.Celular,departamento.NombreDepartamento };
            return Json(new {data=lista});
        }

        public IActionResult Crear()
        {
            return View();
        }
    }
}
