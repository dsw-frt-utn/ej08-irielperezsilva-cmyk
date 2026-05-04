namespace Dsw2026Ej8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ProductHelper.ObtenerEtiquetaProducto (1, "Producto", 100));

            var p2 = new Problema2();
            Console.WriteLine(p2.CrearResumenVenta(1, "Lapiz", 2, 50));

            var prod = new Product("Original");
            var p3 = new Problema3();

            Console.WriteLine(p3.CompararCopias(5, prod)); 

        }
    }
}
