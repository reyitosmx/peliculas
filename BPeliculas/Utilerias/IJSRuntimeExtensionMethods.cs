﻿using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BPeliculas.Utilerias
{
    public static class IJSRuntimeExtensionMethods
    {
        public static async ValueTask<bool> Confirm(this IJSRuntime js, string mensaje)
        {
        
           return await js.InvokeAsync<bool>("confirm",mensaje);
        }
    }
}
