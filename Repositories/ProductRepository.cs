using Microsoft.EntityFrameworkCore;
using AppProductos.Models;
using AppProductos.Data;

namespace AppProductos.Repositories;

public interface IProductoRepository
{
    IEnumerable<Producto> ObtenerTodos();

    void Agregar(Producto producto);

    Producto ObtenerPorId(int id);

    void Actualizar(Producto producto);

    void Eliminar(int id);
}


public class ProductoRepository : IProductoRepository
{
    private readonly AppDbContext _context;

    public ProductoRepository(AppDbContext context)
    {
        _context = context;
    }

    public IEnumerable<Producto> ObtenerTodos()
    {
        return _context.Productos.ToList();
    }

    public void Agregar(Producto producto)
    {
        _context.Productos.Add(producto);
        _context.SaveChanges();
    }

    //changes
    public Producto ObtenerPorId(int id)
    {
        return _context.Productos.Find(id);
    }

    public void Actualizar(Producto producto)
    {
        var productoExistente = _context.Productos.Find(producto.Id);
        if (productoExistente != null)
        {
            // Actualizar las propiedades necesarias
            productoExistente.Nombre = producto.Nombre;
            productoExistente.Categoria = producto.Categoria;
            productoExistente.Precio = producto.Precio;
            productoExistente.Descripcion = producto.Descripcion;
            

            _context.SaveChanges();
        }
    }

    public void Eliminar(int id)
    {
        var producto = _context.Productos.Find(id);
        if (producto != null)
        {
            _context.Productos.Remove(producto);
            _context.SaveChanges();
        }
    }

}