using System.Collections.Generic;
using practica5.core;

namespace practica5.data
{
    public interface IProductRepository
    {
        public IEnumerable<Producto> ObtenerProductos();
        public IEnumerable<Producto> ObtenerProductosPorCategoria(int categoriaId);
        public IEnumerable<Producto> ObtenerProductosRango(decimal minimo,decimal maximo);
        public IEnumerable<Categoria> ObtenerCategorias();
    }
}
