using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesPermisos
{
    public class EntidadUsuario
    {
        public EntidadUsuario(int idUsuario, string nombre, string apellidoP, 
            string apellidoM, string fDN, string rFC, string fkIdAccesos)
        {
            _IdUsuario = idUsuario;
            _Nombre = nombre;
            _ApellidoP = apellidoP;
            _ApellidoM = apellidoM;
            _FDN = fDN;
            _RFC = rFC;
            _FkIdAccesos = fkIdAccesos;
        }

        public int _IdUsuario { get; set; } 
        public string _Nombre { get; set; }  
        public string _ApellidoP { get; set; }   
        public string _ApellidoM { get; set; }   
        public string _FDN { get; set; } 
        public string _RFC { get; set; }
        public string _FkIdAccesos { get; set; }    
    }
}
