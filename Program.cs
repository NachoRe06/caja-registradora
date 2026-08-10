const string NombreComercio = "KIOSCO EL RECREO";
Console.WriteLine($"=== {NombreComercio} ===");
Console.Write("Nombre del cajero: ");
string nombreCajero = Console.ReadLine();
Console.WriteLine($"Bienvenido, {nombreCajero}. Caja abierta.");
Console.Write("Nombre del producto: ");
string nombreProducto = Console.ReadLine();
Console.Write("Precio del producto: ");
string entradaPrecio = Console.ReadLine();
decimal precioProducto = decimal.Parse(entradaPrecio); 
Console.WriteLine($"Producto cargado: {nombreProducto} - Precio: ${precioProducto}");

Console.ReadLine();
