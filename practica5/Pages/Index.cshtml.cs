using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using practica5.core;
using practica5.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace practica5.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IProductRepository _productRepository;
        
        public List<Producto> productos { get; set; }
        public List<SelectListItem> categorias { get; set; }

        public IndexModel(ILogger<IndexModel> logger, IProductRepository productRepository,IHtmlHelper htmlHelper)
        {
            _productRepository = productRepository;
            this.productos = this._productRepository.ObtenerProductos().ToList();
            var categorias=productRepository.ObtenerCategorias().ToList();
            this.categorias = new List<SelectListItem>();
            foreach (var item in categorias)
            {
                this.categorias.Add(new SelectListItem(item.Nombre, item.Id.ToString()));
            }
        }

        public void OnGet()
        {
        }
        public void OnPost(int categoriaId) {
            this.productos = this._productRepository.ObtenerProductosPorCategoria(categoriaId).ToList();
        }
    }
}
