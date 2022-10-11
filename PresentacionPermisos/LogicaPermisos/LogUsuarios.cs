using EntidadesPermisos;
using AccesoDatosPermisos;
using System.Windows.Forms;

namespace LogicaPermisos
{
    public class LogUsuarios
    {
        AccesoDatos ad = new AccesoDatos("localhost", "root", "", "permiso", 3306);
        public string Guardar(EntidadUsuario EU)
        {
            return ad.Comando(string.Format("insert into usuarios values('{0}', '{1}', '{2}', " +
                "'{3}', '{4}', '{5}', '{6}')", EU._RFC, EU._Nombre, EU._ApellidoP, EU._ApellidoM, 
                EU._FDN,EU._FkIdAccesos));
        }
        public void Mostrar(DataGridView tabla, string dato)
        {
            tabla.DataSource = ad.Mostrar(string.Format("select * from usuarios where nombre" +
                "like '%{0}%' or rfc like '%{0}%'", dato), "usuarios").Tables["usuarios"];
            tabla.AutoResizeColumns();
        }
        public string Editar(EntidadUsuario EU)
        {
            return ad.Comando(string.Format("update usuarios set nombre = '{0}', apellidop = '{1}', apellidom = '{2}', " +
                "fdn = '{3}', rfc = '{4}', fkidaccesos = '{5}'" +
                "where idusuario = '{4}'", EU._Nombre, EU._ApellidoP, EU._ApellidoM, EU._FDN, EU._RFC, EU._FkIdAccesos));
        }
        public string Borrar(EntidadUsuario EU)
        {
            string r = "";
            DialogResult rs = MessageBox.Show("Se eliminara el registro definitivamente " + EU._Nombre + " " + EU._ApellidoP + " " + 
                EU._ApellidoM, "Atencion", MessageBoxButtons.YesNo);
            if (rs == DialogResult.Yes)
            {
                r = ad.Comando(string.Format("delete from usuarios where idususuario = '{0}'", EU._IdUsuario));
            }
            return r;
        }
    }
}

