using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Tp2.Models;
using NLog;

namespace Tp2.Controllers
{
    public class HomeController : Controller
    {
        private readonly Logger _logger;

        public HomeController(ILogger<HomeController> logger, Logger log)
        {
            _logger = log;
            _logger.Info("NLog injected into HomeController");
        }

        public IActionResult Index()
        {
            _logger.Warn("Hello, this is the index!");
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Tp2(string name, string lastName, string fechaNacimiento, string tel, string address, string rol, string fechaIngreso)
        {
            try
            {
                if (name != null && lastName != null && tel != null && address != null && rol != null)
                {
                    DateTime nacimiento = DateTime.Parse(fechaNacimiento);
                    DateTime ingreso = DateTime.Parse(fechaIngreso);

                    Empleado nuevoEmpleado = new Empleado(name, lastName, nacimiento, tel, address, rol, ingreso);
                    _logger.Info("Los datos ingresados fueron: " + name + " " + lastName + "," + nuevoEmpleado.Edad + " años ," + nuevoEmpleado.Antiguedad + " de antiguedad y salario $" + nuevoEmpleado.Salario);
                    ViewBag.empleado = nuevoEmpleado;
                }
                else
                {
                    _logger.Error("Se ingresaron campos vacios");
                    ViewBag.mensaje = "Error al ingresar los datos";
                }
            }
            catch(Exception ex)
            {
                _logger.Error(ex.Message);
                ViewBag.mensaje = "Error al procesarse los datos";
            }
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
