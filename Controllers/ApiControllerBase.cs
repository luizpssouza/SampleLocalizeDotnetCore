using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Localization;

namespace dotnet_multilang.Controllers
{
    public class ApiControllerBase : ControllerBase
    {
        public IHtmlLocalizer _localizer;
        
        // public ApiControllerBase(IHtmlLocalizer localizer) 
        // {
        //     this._localizer =  localizer.WithCulture(Thread.CurrentThread.CurrentUICulture);
        // }

        public ApiControllerBase() 
        {
            
        }
    }
}