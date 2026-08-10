const string NombreComercio = "KIOSCO EL RECREO";

// Mostrar el nombre del comercio en la pantalla
Console.WriteLine($"=== {NombreComercio} ===");

// 2. Pedir el nombre del cajero
Console.Write("Nombre del cajero: ");
string nombreCajero = Console.ReadLine();

// 3. Mostrar el saludo usando interpolación
Console.WriteLine($"Bienvenido, {nombreCajero}. Caja abierta.");

// Esto evita que la ventanita negra se cierre de golpe al terminar
Console.ReadLine();
