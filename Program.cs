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

            decimal ventafinal = 0;
            decimal DescuentoAplicado = 0;
            decimal RecargoAplicado = 0;

            if (totalVenta > 50000)
            {
               DescuentoAplicado = totalVenta * DescuentoGrande;
            }
            else if (totalVenta > 20000)
            {
                DescuentoAplicado = totalVenta * DescuentoMediano;
            }
            else
            {
                DescuentoAplicado = totalVenta * SinDescuento;
            }

             ventafinal= totalVenta - DescuentoAplicado;

            const decimal DescuentoEfectivo = 0.10m;
            const decimal RecargoTarjetaCredito = 0.15m;
            string OpcionDePago = "";

            do
            {
                Console.WriteLine("Seleccione el método de pago:");
                Console.WriteLine("1 - Efectivo (10% de descuento)");
                Console.WriteLine("2 - Tarjeta de crédito (15% de recargo)");
                Console.WriteLine("3 - Tarjeta de débito (sin recargo ni descuento)");
                Console.Write("Opción: ");
                OpcionDePago = Console.ReadLine();
                switch (OpcionDePago)
                {
                    case "1":
                        decimal DescuentoEfectivoActual = ventafinal * DescuentoEfectivo;
                        ventafinal = ventafinal - DescuentoEfectivoActual;
                        break;
                    case "2":
                        RecargoAplicado = ventafinal * RecargoTarjetaCredito;
                        ventafinal = ventafinal + RecargoAplicado;
                        break;
                    case "3":
                        ventafinal = ventafinal;
                        break;
                }
            } while (OpcionDePago != "1" && OpcionDePago != "2" && OpcionDePago != "3") ;

            string lineaGuiones = "";
            for (int i = 0; i < 30; i++)
            {
                lineaGuiones = lineaGuiones + "-";
            }

            Console.WriteLine();
            Console.WriteLine(lineaGuiones);
            Console.WriteLine($"{NombreComercio}");
            Console.WriteLine(lineaGuiones);
            Console.WriteLine($"Cajero: {nombreCajero}");
            Console.WriteLine($"Productos: {cantidadProductos}");
            Console.WriteLine($"Subtotal: {totalVenta}");
            Console.WriteLine($"Descuento: {DescuentoAplicado}");
            Console.WriteLine($"Recargo: {RecargoAplicado}");
            Console.WriteLine(lineaGuiones);
            Console.WriteLine($"TOTAL: {ventafinal}");
            Console.WriteLine(lineaGuiones);
            break;
        default:
            Console.WriteLine("Opción inválida, intente nuevamente.");
            break;
    }
} while (opcion != "2");
Console.ReadLine();

