using Entidades.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Servicio.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApplication8.Models;

namespace WebApplication8.Controllers
{
    public class HomeController : Controller
    {
        IBaseRepository<Empleados> _EmpleadoRepository;
        IBaseRepository<Departamento> _DepartamentoRepository;

        public HomeController(IBaseRepository<Empleados> EmpleadoRepository, IBaseRepository<Departamento> departamentoRepository)
        {
            _EmpleadoRepository = EmpleadoRepository;
            _DepartamentoRepository = departamentoRepository;
        }


        public async Task<IActionResult> Index()
        {
            var listaempleado = await _EmpleadoRepository.GetAll();
            var listadepartamento = await _DepartamentoRepository.GetAll();
            ViewBag.CantidadDepartamento = listadepartamento.Count();
            ViewBag.CantidadEmpleado = listaempleado.Count();

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

       
    }
}
