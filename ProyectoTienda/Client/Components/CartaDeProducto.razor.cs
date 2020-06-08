using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoTienda.Client.Components
{
    public class CartaDeProductoBase:ComponentBase
    {
        [Parameter] public string RutaImagenProducto { get; set; }
        [Parameter] public string NombreProducto { get; set; }
        [Parameter] public string PrecioOriginalProducto { get; set; }
        [Parameter] public bool TieneDescuento { get; set; }
        [Parameter] public string Descuento { get; set; }
        [Parameter] public string PrecioFinal { get; set; }
    }
}
