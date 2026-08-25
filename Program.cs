const string NombreComercio = "KIOSCO EL RECREO";
Console.WriteLine($"=== {NombreComercio} ===");
Console.Write("Nombre del cajero: ");
string nombreCajero = Console.ReadLine();
Console.WriteLine($"Bienvenido, {nombreCajero}. Caja abierta.");

int cantidadProductos = 0;
decimal totalVenta = 0;
string opcion = "";

do
{
    Console.WriteLine("Que desea hacer?");
    Console.WriteLine("1 - Cargar un producto");
    Console.WriteLine("2 - Cerrar la venta");
    Console.Write("Opción: ");
    opcion = Console.ReadLine();


    switch (opcion)
    {
        case "1":
            Console.Write("Nombre del producto: ");
            string nombreProducto = Console.ReadLine();
            Console.Write("Precio del producto: ");
            decimal precioProducto = decimal.Parse(Console.ReadLine());
            Console.WriteLine($"Producto cargado: {nombreProducto} - Precio: ${precioProducto}");


            cantidadProductos = cantidadProductos + 1;
            totalVenta = precioProducto + totalVenta;
            break;

        case "2":
            const decimal DescuentoGrande = 0.10m;
            const decimal DescuentoMediano = 0.05m;
            const decimal SinDescuento = 0;

            decimal VentaFinal = 0;

            if (totalVenta > 50000)
            {
                VentaFinal = totalVenta - (totalVenta * DescuentoGrande);   
            }
            else if (totalVenta > 20000)
            {
                VentaFinal = totalVenta - (totalVenta * DescuentoMediano);
            }
            else
            {
                Console.WriteLine("No se aplicó ningún descuento.");
            }

            Console.WriteLine("=== RESUMEN DE LA VENTA ===");
            Console.WriteLine($"Total de productos: {cantidadProductos}");
            Console.WriteLine($"Total de la venta: ${totalVenta}");
            Console.WriteLine($"Total con descuento: ${VentaFinal}");
            break;
        default:
            Console.WriteLine("Opción inválida, intente nuevamente.");
            break;
    }
} while (opcion != "2");
Console.ReadLine();

