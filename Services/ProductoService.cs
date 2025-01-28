using AppProductos.Models;
using AppProductos.Repositories;

namespace AppProductos.Services;

public interface IProductoService
{
    IEnumerable<Producto> ObtenerTodos();

    void Agregar(Producto producto);

    Producto ObtenerPorId(int id);

    void Actualizar(Producto producto);

    void Eliminar(int id);

}

public class ProductoService : IProductoService
{
    private readonly IProductoRepository _productoRepository;

    public ProductoService(IProductoRepository ProductoRepository)
    {
        _productoRepository = ProductoRepository;
    }

    public IEnumerable<Producto> ObtenerTodos()
    {
        return _productoRepository.ObtenerTodos();
    }

    public void Agregar(Producto producto)
    {
        _productoRepository.Agregar(producto);
    }

    public Producto ObtenerPorId(int id)
    {
       return _productoRepository.ObtenerPorId(id);
    }

    public void Actualizar(Producto producto)
    {
        _productoRepository.Actualizar(producto);
    }

    public void Eliminar(int id)
    {
        _productoRepository.Eliminar(id);
    }

}