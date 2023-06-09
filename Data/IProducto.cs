using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProyectoTiendaOnline.Models;

namespace ProyectoTiendaOnline.Data
{
    interface IProducto
    {
        //Definicion de los metodos para el CRUD
        Task<IEnumerable<Producto>> ObtenerAllProductos();

        Task<Producto> DetallesProducto(int id);

        Task<bool> InsertarProducto(Producto Producto);

        Task<bool> UpdateProducto(Producto Producto);

        Task<bool> EliminarProducto(int id);

        Task<bool> GuardarProducto(Producto Producto);
    }
}
