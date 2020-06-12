using Microsoft.AspNetCore.Components;
using ProyectoTienda.Shared.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoTienda.Client.Components
{
    public class CartaDeProductoBase:ComponentBase
    {
        [Parameter] public Producto Producto { get; set; }
    }
}
