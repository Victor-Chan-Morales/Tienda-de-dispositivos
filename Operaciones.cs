using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Tienda_de_dispositivos
{
    public class Operaciones
    {
        private List<Producto> ListaProductos=new List<Producto>();

        public void TipoDispositivo()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Tipos de dispositivos disponibles: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("1. Teléfono");
            Console.WriteLine("2. Tablet");
            Console.WriteLine("3. Ordenador (Computadora)");
            Console.Write("Seleccione una opción:");
        }
        public void AgregarProducto()
        {
            Console.Clear();
            TipoDispositivo();
            Console.ForegroundColor = ConsoleColor.Yellow;
            int tipoDispositivo = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el nombre del producto: ");
            string nombreProducto=Console.ReadLine().ToUpper();
            Console.Write("Ingrese el precio del producto: Q");
            double precioProducto= double.Parse(Console.ReadLine());
            Console.Write("Ingrese la marca del producto: ");
            string marcaProducto = Console.ReadLine();
            switch(tipoDispositivo)
            {
                case 1:
                    Console.Write("Ingrese el sistema operativo del teléfono: ");
                    string sistemaOperativo=Console.ReadLine().ToUpper();
                    string telefono = "TELÉFONO";
                    ListaProductos.Add(new Telefonos(nombreProducto, marcaProducto, precioProducto, sistemaOperativo, telefono));
                    break;
                case 2:
                    Console.Write("Ingrese el peso en kg de la tablet: ");
                    double pesoTablet=double.Parse(Console.ReadLine());
                    string tablet = "TABLET";
                    ListaProductos.Add(new Tablets(nombreProducto, marcaProducto, precioProducto, pesoTablet, tablet));
                    break;
                case 3:
                    Console.Write("Ingrese el procesador del ordenador: ");
                    string procesadorOrdenador = Console.ReadLine().ToUpper();
                    string ordenador = "ORDENADOR";
                    ListaProductos.Add(new Ordenador(nombreProducto, marcaProducto, precioProducto, procesadorOrdenador, ordenador));
                    break;
                default:
                    Console.WriteLine("Opción no disponible...");
                    break;
            }
            Console.ReadKey();
        }
        public void ListarProductos()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("PRODUCTOS DISPONIBLES");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("TABLETAS: ");
            Console.ForegroundColor = ConsoleColor.White;
            foreach (Producto producto in ListaProductos)
            {
                if (producto is Tablets tablet)
                {
                    Console.WriteLine($"Nombre: {tablet.Nombre} --Precio: {tablet.Precio} --Marca: {tablet.Marca} --Tipo: {tablet.Tipo} --Peso: {tablet.Peso}");
                }
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("TELEFONOS: ");
            Console.ForegroundColor = ConsoleColor.White;
            foreach (Producto producto in ListaProductos)
            {
                if (producto is Telefonos telefono)
                {
                    Console.WriteLine($"Nombre: {telefono.Nombre} --Precio: {telefono.Precio} --Marca: {telefono.Marca} --Tipo: {telefono.Tipo} --Sistema: {telefono.Sistema}");
                }
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("ORDENADORES: ");
            Console.ForegroundColor = ConsoleColor.White;
            foreach (Producto producto in ListaProductos)
            {
                if (producto is Ordenador ordenador)
                {
                    Console.WriteLine($"Nombre: {ordenador.Nombre} --Precio: {ordenador.Precio} --Marca: {ordenador.Marca} --Tipo: {ordenador.Tipo} --Procesador: {ordenador.Procesador}");
                }
            }
            Console.ReadKey();
        }
        public void BuscarProducto()
        {
            Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Ingrese el nombre del producto a buscar");
            Console.ForegroundColor = ConsoleColor.White;
            string buscarNombre= Console.ReadLine().ToUpper();
            Producto buscar=ListaProductos.Find(c=>c.Nombre==buscarNombre);
            if ( buscar != null )
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Producto encontrado...");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"Nombre: {buscar.Nombre}--Precio: {buscar.Precio} --Marca: {buscar.Marca} --Tipo: {buscar.Tipo}");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("No se ha encontrado el producto...");
                Console.ForegroundColor = ConsoleColor.White;
            }
            Console.ReadKey();
        }
    }
}
