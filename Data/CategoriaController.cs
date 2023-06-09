using Microsoft.EntityFrameworkCore;
using ProyectoTiendaOnline.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProyectoTiendaOnline.Models;

namespace ProyectoTiendaOnline.Data
{
    public class CategoriaController : ICategoria
    {
        private readonly ApplicationDbContext _context;
        public CategoriaController(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<Categoria> DetallesCategoria(int id)
        {
            return await _context.Categorias.FindAsync(id);
        }

        public async Task<bool> EliminarCategoria(int id)
        {
            var categoria = await _context.Categorias.FindAsync(id);
            _context.Categorias.Remove(categoria);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool> GuardarCategoria(Categoria Categoria)
        {
            if (Categoria.Id > 0)
                return await UpdateCategoria(Categoria);
            else
                return await InsertarCategoria(Categoria);
        }

        public async Task<bool> InsertarCategoria(Categoria Categoria)
        {
            _context.Categorias.Add(Categoria);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<IEnumerable<Categoria>> ObtenerAllCategorias()
        {
            return await _context.Categorias.ToListAsync();
        }

        public async  Task<bool> UpdateCategoria(Categoria Categoria)
        {
            _context.Entry(Categoria).State = EntityState.Modified;
            return await _context.SaveChangesAsync() > 0;
        }
    }
}
