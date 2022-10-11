using System;
using System.Windows.Forms;
using LogicaPermisos;
using EntidadesPermisos;

namespace PresentacionPermisos
{
    public partial class FrmProductos : Form
    {
        EntidadProducto EP;
        LogProductos LP;
        public FrmProductos()
        {
            EP = new EntidadProducto();
            LP = new LogProductos();
            InitializeComponent();
        }
        int i = 0;
        void Actualizar()
        {
            LP.Mostrar(txtbuscar.Text, dtgproductos);
        }

        private void dtgproductos_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            i = e.RowIndex;
            EP._CodigoBarras = dtgproductos.CurrentRow.Cells["codigobarras"].Value.ToString();
            EP._Nombre = dtgproductos.CurrentRow.Cells["nombre"].Value.ToString();
            EP._Descripcion = dtgproductos.CurrentRow.Cells["descripcion"].Value.ToString();
            EP._Marca = dtgproductos.CurrentRow.Cells["marca"].Value.ToString();
        }

    }
}
