using Microsoft.AspNetCore.Mvc;
using PC3.Models;
using PC3.Data;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace PC3.Controllers
{
    public class ProductoController : Controller
    {
        private readonly ProductoContext _context;
        public ProductoController(ProductoContext context) {
            _context = context;
        }

        public IActionResult NuevoProducto() {
            ViewBag.Producto = _context.Productos.ToList().Select(r => new SelectListItem(r.Nombre, r.Id.ToString()));
            return View();
        }

        [HttpPost]
        public IActionResult NuevoProducto(Producto r) {
            if (ModelState.IsValid) {
                _context.Add(r);
                _context.SaveChanges();
                return RedirectToAction("NuevoProductoConfirmacion");
            }
            return View(r);
        }

        public IActionResult NuevoProductoConfirmacion() {
            return View();
        }

    }
}