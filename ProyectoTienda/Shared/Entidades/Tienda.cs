using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoTienda.Shared.Entidades
{
    public class Tienda
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string RUC { get; set; }
        public string Direccion { get; set; }
        public double Latitud { get; set; }
        public double Longitud { get; set; }
        public List<Producto> Productos { get; set; }
    }
}
