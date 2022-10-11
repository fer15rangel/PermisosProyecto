using AccesoDatosPermisos;
using EntidadesPermisos;
using System.Windows.Forms;

namespace LogicaPermisos
{
    public class LogHerramientas
    {
        AccesoDatos ad = new AccesoDatos("localhost", "root", "", "permiso", 3306);
        public string Guardar(EntidadHerramientas EH)
        {
            return ad.Comando(string.Format("insert into herramientas values('{0}', '{1}', '{2}', " +
                "'{3}', '{4}')", EH._CodigoHerramienta, EH._Nombre, EH._Medida, EH._Marca, EH._Descripcion));
        }
        public void Mostrar(DataGridView tabla, string dato)
        {
            tabla.DataSource = ad.Mostrar(string.Format("select * from herramientas where nombre" +
                "like '%{0}%' or codigoherramienta like '%{0}%'", dato), "herramientas").Tables["herramientas"];
            tabla.AutoResizeColumns();
        }
        public string Editar(EntidadHerramientas EH)
        {
            return ad.Comando(string.Format("update herramientas set nombre = '{0}', medida = '{1}', marca = '{2}', descripcion = '{3}'" +
                "where codigoherramienta = '{4}'", EH._Nombre, EH._Medida, EH._Marca, EH._Descripcion, EH._CodigoHerramienta));
        }
        public string Borrar(EntidadHerramientas EH)
        {
            string r = "";
            DialogResult rs = MessageBox.Show("Se eliminara el registro definitivamente " + EH._Descripcion, "Atencion", MessageBoxButtons.YesNo);
            if (rs == DialogResult.Yes)
            {
                r = ad.Comando(string.Format("delete from herramientas where codigoherramientas = '{0}'", EH._CodigoHerramienta));
            }
            return r;
        }
    }
}
