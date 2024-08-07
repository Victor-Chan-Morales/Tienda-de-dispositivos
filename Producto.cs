using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Tienda_de_dispositivos
{
    public class Producto
    {
        public string Nombre { get; set; }
        public string  Marca { get; set; }
        public double Precio { get; set; }
        public string Tipo { get; set; }

        public Producto(string nombre, string marca, double precio, string tipo)
        {
            Nombre = nombre;
            Marca = marca;
            Precio = precio;
            Tipo=tipo;
        }
        
        
    }
}
