using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesPermisos
{
    public class EntidadProducto
    {
        public EntidadProducto(int codigoBarras, string nombre, 
            string descripcion, string marca)
        {
            _CodigoBarras = codigoBarras;
            _Nombre = nombre;
            _Descripcion = descripcion;
            _Marca = marca;
        }

        public int _CodigoBarras { get; set; }  
        public string _Nombre { get; set; } 
        public string _Descripcion { get; set; } 
        public string _Marca { get; set; }  
    }
}
