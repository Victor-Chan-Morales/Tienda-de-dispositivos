
using Tienda_de_dispositivos;

Operaciones operaciones = new Operaciones();
bool ingresar = true;
while (ingresar)
{
    try
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("MENÚ PRINCIPAL");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("1. AGREGAR PRODUCTO");
        Console.WriteLine("2. BUSCAR PRODUCTO");
        Console.WriteLine("3. LISTAR PRODUCTO");
        Console.WriteLine("4. SALIR DEL PROGRAMA");
        Console.Write("SELECCIONE UNA OPCIÓN: ");
        int opcionMenuPrincipal=int.Parse(Console.ReadLine());
        Console.ForegroundColor = ConsoleColor.White;
        switch (opcionMenuPrincipal)
        {
            case 1:
                operaciones.AgregarProducto();
                break;
            case 2:
                operaciones.BuscarProducto();
                break;
            case 3:
                operaciones.ListarProductos();
                break;
            case 4:
                ingresar = false;
                break;
            default:
                Console.WriteLine("Esta opción no está disponible. Ingrese una opción correcta."); Console.ReadKey(true);    
                break;
        }
    }
    catch (FormatException)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Error: ha ingresado un caracter inválido...");
        Console.ReadKey();
    }
}
