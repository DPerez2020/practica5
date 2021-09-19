using practica5.core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica5.data
{
    public class ProductoRepository : IProductRepository
    {
        private readonly List<Producto> productos;
        private readonly List<Categoria> categorias;
        public ProductoRepository()
        {
            categorias = new List<Categoria>() {
                new Categoria(){Id=1,Nombre="Electrodomesticos"},
                new Categoria(){Id=2,Nombre="Frutas"},
                new Categoria(){Id=3,Nombre="Decoracion"},
                new Categoria(){Id=4,Nombre="Automoviles"},
                new Categoria(){Id=5,Nombre="Informatica"}
            };
            productos = new List<Producto>()
            {
                new Producto() {Id=1,Nombre="Mango",CategoriaId=2,Marca="Anonima",Modelo="Anonima",Precio=20 },
                new Producto() {Id=2,Nombre="Nevera",CategoriaId=1,Marca="LG",Modelo="Anonima",Precio=35000 },
                new Producto() {Id=3,Nombre="Lampara",CategoriaId=3,Marca="Anonima",Modelo="Anonima",Precio=3500 },
                new Producto() {Id=4,Nombre="Alfombra",CategoriaId=3,Marca="Anonima",Modelo="Anonima",Precio=20 },
                new Producto() {Id=5,Nombre="Manzana",CategoriaId=2,Marca="Anonima",Modelo="Anonima",Precio=50 },
                new Producto() {Id=6,Nombre="Neumatico",CategoriaId=4,Marca="Anonima",Modelo="Anonima",Precio=5000 },
                new Producto() {Id=7,Nombre="Asiento",CategoriaId=4,Marca="Anonima",Modelo="Anonima",Precio=4000 },
                new Producto() {Id=8,Nombre="Estufa",CategoriaId=1,Marca="Anonima",Modelo="Anonima",Precio=25000 },
                new Producto() {Id=9,Nombre="Platano",CategoriaId=2,Marca="Anonima",Modelo="Anonima",Precio=100 },
                new Producto() {Id=10,Nombre="Corchas",CategoriaId=3,Marca="Anonima",Modelo="Anonima",Precio=3000 },
            };            
        }
        public IEnumerable<Categoria> ObtenerCategorias()
        {
            var resultado = (from a in productos
                            join b in categorias
                            on a.CategoriaId equals b.Id
                            select b).Distinct() ;
            return resultado;
        }

        public IEnumerable<Producto> ObtenerProductos()
        {
            return productos;
        }

        public IEnumerable<Producto> ObtenerProductosPorCategoria(int categoriaId)
        {
            var resultado = from a in productos
                            where a.CategoriaId == categoriaId
                            select a;
            return resultado;
        }

        public IEnumerable<Producto> ObtenerProductosRango(decimal minimo, decimal maximo)
        {
            var resultado = from a in productos
                            where a.Precio>=minimo && a.Precio<=maximo
                            orderby a.Precio descending
                            select a;                          
            return resultado;
        }
    }
}
