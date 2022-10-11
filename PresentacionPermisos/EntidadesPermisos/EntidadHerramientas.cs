using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesPermisos
{
    public class EntidadHerramientas
    {
        public EntidadHerramientas(int codigoHerramienta, string nombre, 
            string medida, string marca, string descripcion)
        {
            _CodigoHerramienta = codigoHerramienta;
            _Nombre = nombre;
            _Medida = medida;
            _Marca = marca;
            _Descripcion = descripcion;
        }

        public int _CodigoHerramienta { get; set; } 
        public string _Nombre { get; set; }
        public string _Medida { get; set; } 
        public string _Marca { get; set; }
        public string _Descripcion { get; set; } 
    }
}
