using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using practica5.core;
using practica5.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace practica5.Pages
{
    public class PrivacyModel : PageModel
    {
        private readonly ILogger<PrivacyModel> _logger;
        public List<Producto> productos { get; set; }

        public PrivacyModel(ILogger<PrivacyModel> logger,IProductRepository productoRepository)
        {
            _logger = logger;
            this.productos = productoRepository.ObtenerProductosRango(3000, 5000).ToList();
        }

        public void OnGet()
        {
        }
    }
}
