using EntidadesPermisos;
using AccesoDatosPermisos;
using System.Windows.Forms;

namespace LogicaPermisos
{
    public class LogProductos
    {
        AccesoDatos ad = new AccesoDatos("localhost", "root", "", "permiso", 3306);
        public string Guardar(EntidadProducto EP)
        {
            return ad.Comando(string.Format("insert into producto values('{0}', '{1}', '{2}', " +
                "'{3}')", EP._CodigoBarras, EP._Nombre, EP._Descripcion, EP._Marca));
        }
        public void Mostrar(DataGridView tabla, string dato)
        {
            tabla.DataSource = ad.Mostrar(string.Format("select * from producto where nombre" +
                "like '%{0}%' or codigobarras like '%{0}%'", dato), "producto").Tables["producto"];
            tabla.AutoResizeColumns();
        }
        public string Editar(EntidadProducto EP)
        {
            return ad.Comando(string.Format("update producto set nombre = '{0}', descripcion = '{1}', marca = '{2}'" +
                "where codigobarras = '{3}'", EP._Nombre, EP._Descripcion, EP._Marca,EP._CodigoBarras));
        }
        public string Borrar(EntidadProducto EP)
        {
            string r = "";
            DialogResult rs = MessageBox.Show("Se eliminara el registro definitivamente " + EP._Descripcion, "Atencion", MessageBoxButtons.YesNo);
            if (rs == DialogResult.Yes)
            {
                r = ad.Comando(string.Format("delete from herramientas where codigoherramientas = '{0}'", EP._CodigoBarras));
            }
            return r;
        }
    }
}



