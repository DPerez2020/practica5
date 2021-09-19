using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using practica5.core;
using practica5.data;

namespace practica5.Pages
{
    public class ejercicio3Model : PageModel
    {
        public List<Categoria> categorias { get; set; }
        public ejercicio3Model(IProductRepository productRepository)
        {
            this.categorias = productRepository.ObtenerCategorias().ToList();
        }
        public void OnGet()
        {
        }
    }
}
