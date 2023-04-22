using Microsoft.AspNetCore.Mvc;
using PROG_FINAL_prueba_3.Models;

namespace PROG_FINAL_prueba_3.Controllers
{
    public class PrestamosController : Controller
    {
        private static List<Prestamo> _prestamos = new List<Prestamo>();
      
        public IActionResult Index()
        {
            return View(_prestamos);
        }

        public IActionResult Registrar(Prestamo prestamo)
        {
            prestamo.Id = _prestamos.Count + 1;
            if (prestamo.Id > 0 && prestamo.Nombre != "0" && prestamo.Monto > 0)
            {
                _prestamos.Add(prestamo);
            }
            return View(_prestamos);
        }
       
        //[HttpPost, ActionName("EliminarDesdeIndex")]
        //[ValidateAntiForgeryToken]
        //public ActionResult EliminarDesdeIndex(int id)
        //{
        //    var prestamo = _prestamos.FirstOrDefault(p => p.Id == id);
        //    if (prestamo == null)
        //    {
        //        return NotFound();
        //    }

        //    _prestamos.Remove(prestamo);

        //    return RedirectToAction("Registrar");
        //}

        [HttpPost]
        public ActionResult Eliminar(int id)
        {
            var prestamo = _prestamos.FirstOrDefault(p => p.Id == id);
            if (prestamo == null)
            {
                return Json(new { success = false });
            }

            _prestamos.Remove(prestamo);

            return Json(new { success = true });
        }

        public ActionResult Editar(int id)
        {
            // Obtener el préstamo con el ID proporcionado
            var prestamo = _prestamos.FirstOrDefault(p => p.Id == id);

            if (prestamo == null)
            {
                // Manejar el caso donde el préstamo no existe
                return NotFound();
            }

            // Devolver la vista de edición con el modelo del préstamo
            return View(prestamo);

        }
        public ActionResult cuota(int id)
        {
           
            var prestamo = _prestamos.FirstOrDefault(p => p.Id == id);

            if (prestamo == null)
            {
                
                return NotFound();
            }

            
            return View(prestamo);

        }
    }
}
   //if (prestamo.cuotaspendientes > 0)
   //             {
   //                 prestamo.cuotaspendientes--;
   //                 return View(prestamo);
   //             }         
              