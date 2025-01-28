using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using AppProductos.Models;
using AppProductos.Services;

namespace AppProductos.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    private readonly IProductoService _productoService;

    public HomeController(ILogger<HomeController> logger, IProductoService productoService)
    {
        _logger = logger;
        _productoService = productoService;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult Products()
    {
        var productos = _productoService.ObtenerTodos();
        return View(productos);
    }

    public IActionResult AddProduct()
    {
        return View();
    }

    [HttpPost]
    public IActionResult AddProduct(Producto producto)
    {
        if (ModelState.IsValid)
        {
            _productoService.Agregar(producto);
            return RedirectToAction("Products");
        }
        return View(producto);

    }

    [HttpPost]
    public IActionResult EditProduct(Producto producto)
    {
        if (ModelState.IsValid)
        {
            try
            {
                _productoService.Actualizar(producto);
                TempData["Success"] = "Producto actualizado correctamente.";
                return RedirectToAction("Products");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "Error al actualizar el producto: " + ex.Message);
            }
        }
        return View(producto);
    }

    [HttpGet]
    public IActionResult EditProduct(int id)
    {
        var producto = _productoService.ObtenerPorId(id);
        if (producto == null)
        {
            return NotFound();
        }
        return View(producto);
    }

    [HttpPost]
    public IActionResult DeleteProduct(int id)
    {
        var producto = _productoService.ObtenerPorId(id);
        if (producto == null)
        {
            TempData["Error"] = "El producto no fue encontrado.";
            return RedirectToAction("Products");
        }

        try
        {
            _productoService.Eliminar(id);
            TempData["Success"] = "Producto eliminado correctamente.";
        }
        catch (Exception ex)
        {
            TempData["Error"] = "Error al eliminar el producto: " + ex.Message;
        }

        return RedirectToAction("Products");
    }



    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
