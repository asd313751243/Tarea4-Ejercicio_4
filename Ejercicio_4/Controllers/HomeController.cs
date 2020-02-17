using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Ejercicio_4.Models;
using Ejercicio_4.Helpers;

namespace Ejercicio_4.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Sumar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Sumar(Valores a)
        {
            if (ModelState.IsValid)
            {
                a.result = Calcular.sumar(a.numero1, a.numero2);
                return RedirectToAction("Resultado", a);
            }
            return View(a);
        }

        public IActionResult Restar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Restar(Valores a)
        {
            if (ModelState.IsValid)
            {
                a.result = Calcular.restar(a.numero1, a.numero2);
                return RedirectToAction("Resultado", a);
            }
            return View(a);
        }

        public IActionResult Multiplicar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Multiplicar(Valores a)
        {
            if (ModelState.IsValid)
            {
                a.result = Calcular.multiplicar(a.numero1, a.numero2);
                return RedirectToAction("Resultado", a);
            }
            return View(a);
        }

        public IActionResult Dividir()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Dividir(Valores a)
        {
            if (ModelState.IsValid)
            {
                a.result = Calcular.dividir(a.numero1, a.numero2);
                return RedirectToAction("Resultado", a);
            }
            return View(a);
        }

        public IActionResult Al2()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Al2(Valores a)
        {
            if (ModelState.IsValid)
            {
                a.result = Calcular.al2(a.numero1, a.numero2);
                return RedirectToAction("Resultado", a);
            }
            return View(a);
        }

        public IActionResult Al3()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Al3(Valores a)
        {
            if (ModelState.IsValid)
            {
                a.result = Calcular.al3(a.numero1, a.numero2);
                return RedirectToAction("Resultado", a);
            }
            return View(a);
        }

        public IActionResult Aly()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Aly(Valores a)
        {
            if (ModelState.IsValid)
            {
                a.result = Calcular.aly(a.numero1, a.numero2);
                return RedirectToAction("Resultado", a);
            }
            return View(a);
        }

        public IActionResult Log()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Log(Valores a)
        {
            if (ModelState.IsValid)
            {
                a.result = Calcular.log(a.numero1, a.numero2);
                return RedirectToAction("Resultado", a);
            }
            return View(a);
        }

        public IActionResult Porcentaje()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Porcentaje(Valores a)
        {
            if (ModelState.IsValid)
            {
                a.result = Calcular.porcentaje(a.numero1, a.numero2);
                return RedirectToAction("Resultado", a);
            }
            return View(a);
        }

        public IActionResult Seno()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Seno(Valores a)
        {
            if (ModelState.IsValid)
            {
                a.result = Calcular.seno(a.numero1, a.numero2);
                return RedirectToAction("Resultado", a);
            }
            return View(a);
        }

        public IActionResult Coseno()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Coseno(Valores a)
        {
            if (ModelState.IsValid)
            {
                a.result = Calcular.coseno(a.numero1, a.numero2);
                return RedirectToAction("Resultado", a);
            }
            return View(a);
        }

        public IActionResult Tangente()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Tangente(Valores a)
        {
            if (ModelState.IsValid)
            {
                a.result = Calcular.tangente(a.numero1, a.numero2);
                return RedirectToAction("Resultado", a);
            }
            return View(a);
        }

        public IActionResult Resultado(Valores a)
        {
            return View(a);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
