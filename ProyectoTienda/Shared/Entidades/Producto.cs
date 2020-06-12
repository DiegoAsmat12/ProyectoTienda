using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoTienda.Shared.Entidades
{
    public class Producto
    {
        public int Id { get; set; }
        public string NombreProducto { get; set; }
        public string RutaImagenProducto { get; set; }
        public string PrecioOriginalProducto { get; set; }
        public string Descuento { get; set; }
        public string PrecioFinal { get; set; }
        public Tienda Tienda { get; set; }
    }
}
