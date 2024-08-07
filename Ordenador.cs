using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda_de_dispositivos
{
    public class Ordenador: Producto
    {
        public string Procesador { get; set; }
        public Ordenador(string nombre, string marca, double precio, string procesador, string tipo) : base(nombre, marca, precio, tipo)
        {
            Procesador = procesador;
        }
    }
}
