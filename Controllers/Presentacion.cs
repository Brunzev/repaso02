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
    public class Presentacion : Controller
    {
            public IActionResult Presentar(){
            return View();
        }
            public IActionResult Formulario(){
            return View();
        }
            public IActionResult Servicio(){
            return View();
        }
    }
}