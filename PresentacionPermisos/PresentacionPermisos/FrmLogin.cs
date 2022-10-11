using System;
using System.Drawing;
using System.Windows.Forms;
using LogicaPermisos;

namespace PresentacionPermisos
{
    public partial class FrmLogin : Form
    {
        public static string val = "";
        LogPermisos LP;
        public FrmLogin()
        {
            InitializeComponent();
            LP = new LogPermisos(); 
        } 
        private void txtusuario_Enter(object sender, EventArgs e)
        {
            if (txtusuario.Text == "")
            {
                txtusuario.Text = "Usuario";
                txtusuario.ForeColor = Color.White;
            }
        }

        private void txtusuario_Leave(object sender, EventArgs e)
        {
            if (txtusuario.Text == "")
            {
                txtusuario.Text = "Usuario";
                txtusuario.ForeColor = Color.White;
            }
        }

        private void txtcontraseña_Enter(object sender, EventArgs e)
        {
            if (txtcontraseña.Text == "")
            {
                txtcontraseña.Text = "Contraseña";
                txtcontraseña.ForeColor = Color.White;
                txtcontraseña.UseSystemPasswordChar = true; 
            }
        }

        private void txtcontraseña_Leave(object sender, EventArgs e)
        {
            if (txtcontraseña.Text == "")
            {
                txtcontraseña.Text = "Contraseña";
                txtcontraseña.ForeColor = Color.White;
                txtcontraseña.UseSystemPasswordChar = false;
            }
        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmRegistrar FR = new FrmRegistrar();
            FR.Show();
        }

        private void btnsesion_Click(object sender, EventArgs e)
        {
            int v = LP.ValidarUsuario(txtusuario.Text , txtcontraseña.Text);
            if (v == 1)
            {
                this.Hide();
                val = LP.Acceso(txtusuario.Text);
                FrmPrincipal FP = new FrmPrincipal();
                FP.Show();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrecta");
            }
        }
    }
}
