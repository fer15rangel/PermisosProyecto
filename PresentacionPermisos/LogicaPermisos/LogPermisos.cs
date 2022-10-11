using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccesoDatosPermisos;
using EntidadesPermisos;

namespace LogicaPermisos
{
    public class LogPermisos
    {
        public AccesoDatos _base;
        public LogPermisos()
        {
            _base = new AccesoDatos("localhost", "root", "", "permiso", 3306);
        }
        public string Guardar(EntidadUsuario EU)
        {
            return _base.Comando(string.Format("Insert into usuarios values('{0}', '{1}', '{2}', " +
                "'{3}', '{4}', '{5}', '{6}')", EU._IdUsuario, EU._Nombre, EU._ApellidoP, EU._ApellidoM,
                EU._FDN, EU._RFC, EU._FkIdAccesos));
        }
        public int Login(string LUsuario, string LContraseña)
        {
            string consulta = string.Format("select count(*) from usuarios where rfc = '{0}' " +
                "and contraseña = '{1}';", LUsuario, LContraseña);
            int c = int.Parse(_base.ConsultaRetorno(consulta));
            return c;
        }
        public int ValidarUsuario(string VUsuario, string VContraseña )
        {
            int c = 0;
            try
            {
                c = Login(VUsuario, VContraseña);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Validacion erronea" + ex.Message);
            }
            return c;
        }
        public string Accesos(string accesos)
        {
            string consulta = string.Format("select idaccesos from accesos where idaccesos = '{0}';", accesos);
            string c = _base.ConsultaRetorno(consulta);
            return c;
        }
        public string Acceso(string rfc)
        {
            string consulta = string.Format("select fkidaccesos from usuarios where rfc = '{0}';", rfc);
            string c = _base.ConsultaRetorno(consulta);
            return c;
        }   
     
    }
}
