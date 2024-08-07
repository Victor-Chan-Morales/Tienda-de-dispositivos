using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Tienda_de_dispositivos
{
    public class Tablets:Producto
    {
        public double Peso { get; set; }
        public Tablets(string nombre, string marca, double precio, double peso, string tipo) : base(nombre, marca, precio, tipo)
        {
            Peso = peso;
        }
        
    }
}
