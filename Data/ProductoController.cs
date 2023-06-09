using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProyectoTiendaOnline.Models;
using ProyectoTiendaOnline.Data;

namespace ProyectoTiendaOnline.Data
{
    public class ProductoController : IProducto
    {
        private readonly ApplicationDbContext _context;
        public ProductoController(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<Producto> DetallesProducto(int id)
        {
            return await _context.Productos.FindAsync(id);
        }

        public async Task<bool> EliminarProducto(int id)
        {
            var producto = await _context.Productos.FindAsync(id);
            _context.Productos.Remove(producto);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool> GuardarProducto(Producto Producto)
        {
            if (Producto.Id > 0)
                return await UpdateProducto(Producto);
            else
                return await InsertarProducto(Producto);
        }

        public async Task<bool> InsertarProducto(Producto Producto)
        {
            _context.Productos.Add(Producto);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<IEnumerable<Producto>> ObtenerAllProductos()
        {
            return await _context.Productos.ToListAsync();
        }

        public async Task<bool> UpdateProducto(Producto Producto)
        {
            _context.Entry(Producto).State = EntityState.Modified;
            return await _context.SaveChangesAsync() > 0;
        }
    }
}
