using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicaPermisos;

namespace PresentacionPermisos
{
    public partial class FrmPrincipal : Form
    {
        LogPermisos LP;
        public FrmPrincipal()
        {
            InitializeComponent();
            btnadmi.Hide();
            if (FrmLogin.val == "Administrador")
            {
                btnadmi.Show();
            }
        }
        public static Form frmactivo = null;
        public static Form frmhijo;

        public void AbreFrmHijo(Form frmhijo)
        {
            if (frmactivo != null)
            {
                frmactivo.Close();
            }
            frmactivo = frmhijo;
            frmhijo.TopLevel = false;
            frmhijo.Dock = DockStyle.Fill;
            pnlcontenido.Controls.Add(frmhijo);
            pnlcontenido.Tag = frmhijo;
            frmhijo.BringToFront();
            frmhijo.Show();
        }

        private void btninicio_Click(object sender, EventArgs e)
        {
            pnlcontenido.BringToFront();
        }

        private void btnproducto_Click(object sender, EventArgs e)
        {
            AbreFrmHijo(new FrmProductos());
        }

        private void btnherramientas_Click(object sender, EventArgs e)
        {
            AbreFrmHijo(new FrmHerramientas());
        }

        private void btnadmi_Click(object sender, EventArgs e)
        {
            AbreFrmHijo(new FrmAdmi());
        }
    }
}
