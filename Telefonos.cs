using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda_de_dispositivos
{
    public class Telefonos : Producto
    {
         public string Sistema {  get; set; }

        public Telefonos(string nombre, string marca, double precio, string sistema, string tipo) : base(nombre, marca, precio, tipo)
        {
            Sistema = sistema;
        }
        

    }
}
