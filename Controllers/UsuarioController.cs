using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using repaso02.Models;

namespace repaso02.Controllers
{
    public class UsuarioController : Controller
    {
        public IActionResult Index(){
            return View();
        }

        [HttpPost]
        public IActionResult Guardar(string nombre, string apellido, string motivo, string mensaje){
            
            Console.WriteLine(nombre);
            Console.WriteLine(apellido);
            Console.WriteLine(motivo);
            Console.WriteLine(mensaje);
            return RedirectToAction("Index");

        }

        public IActionResult Iniciar(){
            return View();
        }
    }
}