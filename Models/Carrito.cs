using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoTiendaOnline.Models
{
    public class Carrito
    {
        public int Id { get; set; }

        public int CantidadProductos { get; set; }

        public double TotalProductos { get; set; }

        public DateTime Fecha { get; set; }


        //Agregando la foreing key de la tabla producto
        public int ProductoId { get; set; }

        public Producto Producto { get; set; }

    }
}
