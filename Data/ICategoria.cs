using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProyectoTiendaOnline.Models;

namespace ProyectoTiendaOnline.Data
{
    public interface ICategoria
    {
        //Definicion de los metodos para el CRUD
        Task<IEnumerable<Categoria>> ObtenerAllCategorias();

        Task<Categoria> DetallesCategoria(int id);

        Task<bool> InsertarCategoria(Categoria Categoria);

        Task<bool> UpdateCategoria(Categoria Categoria);

        Task<bool> EliminarCategoria(int id);

        Task<bool> GuardarCategoria(Categoria Categoria);
    }
}
