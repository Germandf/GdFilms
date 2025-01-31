﻿using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorFilmCatalogCourse.Client.Helpers
{
    public static class IJSRuntimeExtensionMethods
    {
        public static ValueTask<object> SetInLocalStorage(this IJSRuntime js, string key, string content) 
            => js.InvokeAsync<object>("localStorage.setItem", key, content);

        public static ValueTask<string> GetFromLocalStorage(this IJSRuntime js, string key) 
            => js.InvokeAsync<string>("localStorage.getItem", key);
        
        public static ValueTask<object> RemoveItem(this IJSRuntime js, string key) 
            => js.InvokeAsync<object>("localStorage.removeItem", key);

        public static async ValueTask StartInactiveTime<T>(this IJSRuntime js, 
            DotNetObjectReference<T> dotNetObjectReference) where T: class
        {
            await js.InvokeVoidAsync("inactiveTimer", dotNetObjectReference);
        }
    }
}
