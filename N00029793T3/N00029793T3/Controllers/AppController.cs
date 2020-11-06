using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using N00029793T3.IClases;
using N00029793T3.Models;

namespace N00029793T3.Controllers
{
    public class AppController : BaseController
    {
        private readonly N00029793Context _context;
        private readonly IFacil Facil;
        private readonly IIntermedio Intermedio;
        private readonly IDificil Dificil;
        


        public AppController(N00029793Context context, IFacil Facil, IIntermedio Intermedio, IDificil Dificil) : base(context)
        {
            this._context = context;
            this.Facil = Facil;
            this.Intermedio = Intermedio;
            this.Dificil = Dificil;
        }
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Rutinas = _context.Rutinas
                .Where(x => x.IdUsuario == LoggedUser().Id)
                .ToList()
                .OrderByDescending(c => c.FechaCreacion);
            return View();
        }
        [HttpGet]
        public IActionResult CrearR()
        {
            return View(new Rutina());
        }
        [HttpPost]
        public IActionResult CrearR(Rutina rutina)
        {
            rutina.FechaCreacion = DateTime.Now;
            rutina.IdUsuario = LoggedUser().Id;
            if (ModelState.IsValid)
            {
                _context.Rutinas.Add(rutina);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(rutina);
        }
        [HttpGet]
        public IActionResult Probar(int id)
        {
            Rutina ru = _context.Rutinas.Where(o => o.Id == id).FirstOrDefault();
            int id1 = 0;
            if (ru.Nivel == 1)
            {
                id1 = ru.Id;
                Facil.FacilR(id1);
                return RedirectToAction("Index");
            }
            if (ru.Nivel == 2)
            {
                id1 = ru.Id;
                Intermedio.IntermedioR(id1);
                return RedirectToAction("Index");
            }
            if (ru.Nivel == 3)
            {
                id1 = ru.Id;
                Dificil.DificilR(id1);
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult AsignarN(int id)
        {
            var rut = _context.Rutinas.Where(o => o.Id == id).FirstOrDefault();
            return View(rut);
        }
        [HttpPost]
        public ActionResult AsignarN(Rutina rut)
        {
            int i = rut.Id;
            if (ModelState.IsValid)
            {
                _context.Rutinas.Update(rut);
                _context.SaveChanges();
                return RedirectToAction("Probar", new { id = i} );
            }
            return View(rut);
        }
        [HttpGet]
        public ActionResult EjercicioL(int id)
        {
            ViewBag.Lista = _context.DetalleRutinas.Where(o => o.IdRutina == id).Include(x => x.ejercicio).ToList();
            return View();
        }
    }
}
