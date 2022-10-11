namespace PresentacionPermisos
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btninicio = new System.Windows.Forms.Button();
            this.btnproducto = new System.Windows.Forms.Button();
            this.btnherramientas = new System.Windows.Forms.Button();
            this.btnadmi = new System.Windows.Forms.Button();
            this.pnlcontenido = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btninicio
            // 
            this.btninicio.Location = new System.Drawing.Point(1, 12);
            this.btninicio.Name = "btninicio";
            this.btninicio.Size = new System.Drawing.Size(105, 23);
            this.btninicio.TabIndex = 0;
            this.btninicio.Text = "INICIO";
            this.btninicio.UseVisualStyleBackColor = true;
            this.btninicio.Click += new System.EventHandler(this.btninicio_Click);
            // 
            // btnproducto
            // 
            this.btnproducto.Location = new System.Drawing.Point(1, 41);
            this.btnproducto.Name = "btnproducto";
            this.btnproducto.Size = new System.Drawing.Size(105, 23);
            this.btnproducto.TabIndex = 1;
            this.btnproducto.Text = "PRODUCTOS";
            this.btnproducto.UseVisualStyleBackColor = true;
            this.btnproducto.Click += new System.EventHandler(this.btnproducto_Click);
            // 
            // btnherramientas
            // 
            this.btnherramientas.Location = new System.Drawing.Point(1, 70);
            this.btnherramientas.Name = "btnherramientas";
            this.btnherramientas.Size = new System.Drawing.Size(105, 23);
            this.btnherramientas.TabIndex = 2;
            this.btnherramientas.Text = "HERRAMIENTAS";
            this.btnherramientas.UseVisualStyleBackColor = true;
            this.btnherramientas.Click += new System.EventHandler(this.btnherramientas_Click);
            // 
            // btnadmi
            // 
            this.btnadmi.Location = new System.Drawing.Point(1, 99);
            this.btnadmi.Name = "btnadmi";
            this.btnadmi.Size = new System.Drawing.Size(105, 23);
            this.btnadmi.TabIndex = 3;
            this.btnadmi.Text = "ADMINISTRADOR";
            this.btnadmi.UseVisualStyleBackColor = true;
            this.btnadmi.Click += new System.EventHandler(this.btnadmi_Click);
            // 
            // pnlcontenido
            // 
            this.pnlcontenido.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pnlcontenido.Location = new System.Drawing.Point(112, 12);
            this.pnlcontenido.Name = "pnlcontenido";
            this.pnlcontenido.Size = new System.Drawing.Size(291, 208);
            this.pnlcontenido.TabIndex = 4;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(415, 232);
            this.Controls.Add(this.pnlcontenido);
            this.Controls.Add(this.btnadmi);
            this.Controls.Add(this.btnherramientas);
            this.Controls.Add(this.btnproducto);
            this.Controls.Add(this.btninicio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPrincipal";
            this.Text = "FrmPrincipal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btninicio;
        private System.Windows.Forms.Button btnproducto;
        private System.Windows.Forms.Button btnherramientas;
        private System.Windows.Forms.Button btnadmi;
        private System.Windows.Forms.Panel pnlcontenido;
    }
}