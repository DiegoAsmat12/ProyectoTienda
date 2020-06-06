using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoTienda.Client.Components
{
    public class CarouselBase:ComponentBase
    {
        [Parameter] public List<string> ImageSource { get; set; } 

    }
}