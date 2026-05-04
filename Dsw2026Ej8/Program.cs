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


            var p4 = new Problema4();
            Console.WriteLine(p4.CalcularPromedio(10, null, 8));


            var p5 = new Problema5();

            Sale s1 = new RetailSale(100);
            Sale s2 = new WholesaleSale(100);

            Console.WriteLine(p5.ObtenerImporteFinal(s1));
            Console.WriteLine(p5.ObtenerImporteFinal(s2));


            var p6 = new Problema6();

            Console.WriteLine(p6.NormalizarCodigoProducto(" ab 123 x"));
            Console.WriteLine(p6.NormalizarCodigoProducto(null)); 




        }
    }
}
