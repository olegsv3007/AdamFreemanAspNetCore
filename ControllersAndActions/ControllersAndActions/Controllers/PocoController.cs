using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace ControllersAndActions.Controllers
{
    public class PocoController
    {
        public ViewResult Index() => new ViewResult()
        {
            ViewName = "Result",
            ViewData = new ViewDataDictionary(new EmptyModelMetadataProvider(), new ModelStateDictionary())
            {
                Model = $"This is a POCO controller"
            }
        };
    }
}