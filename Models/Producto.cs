using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoTiendaOnline.Models
{
    public class Producto
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public DateTime FechaPublicacion { get; set; }

        public double Precio { get; set; }

        public string Descripcion { get; set; }


        public string UserId { get; set; }
        //Agregando la foreing key de la tabla categoria
        public int CategoriaId { get; set; }

        public Categoria Categoria { get; set; }


        

        public IEnumerable<Carrito> Carritos { get; set; }
    }
}
