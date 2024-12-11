using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dd
{
    public class producto
    {

        public int id { get; set; }

        public string nombre { get; set; }
        public int cantidad { get; set; }
        public int precio { get; set; }



       public producto() { }
        
        public producto(int id, string nombre, int cantidad, int precio)
        {
            this.id = id;
            this.nombre = nombre;
            this.cantidad = cantidad;
            this.precio = precio;

        }
    }
}
