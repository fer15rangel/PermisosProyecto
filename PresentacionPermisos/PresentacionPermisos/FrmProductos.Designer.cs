namespace PresentacionPermisos
{
    partial class FrmProductos
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
            this.pnlcontenido = new System.Windows.Forms.Panel();
            this.btnadmi = new System.Windows.Forms.Button();
            this.btnherramientas = new System.Windows.Forms.Button();
            this.btnproducto = new System.Windows.Forms.Button();
            this.btninicio = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.btnañadirp = new System.Windows.Forms.Button();
            this.dtgproductos = new System.Windows.Forms.DataGridView();
            this.pnlcontenido.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgproductos)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlcontenido
            // 
            this.pnlcontenido.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pnlcontenido.Controls.Add(this.dtgproductos);
            this.pnlcontenido.Controls.Add(this.btnañadirp);
            this.pnlcontenido.Controls.Add(this.txtbuscar);
            this.pnlcontenido.Controls.Add(this.panel1);
            this.pnlcontenido.Location = new System.Drawing.Point(112, 12);
            this.pnlcontenido.Name = "pnlcontenido";
            this.pnlcontenido.Size = new System.Drawing.Size(354, 293);
            this.pnlcontenido.TabIndex = 9;
            // 
            // btnadmi
            // 
            this.btnadmi.Location = new System.Drawing.Point(1, 99);
            this.btnadmi.Name = "btnadmi";
            this.btnadmi.Size = new System.Drawing.Size(105, 23);
            this.btnadmi.TabIndex = 8;
            this.btnadmi.Text = "ADMINISTRADOR";
            this.btnadmi.UseVisualStyleBackColor = true;
            // 
            // btnherramientas
            // 
            this.btnherramientas.Location = new System.Drawing.Point(1, 70);
            this.btnherramientas.Name = "btnherramientas";
            this.btnherramientas.Size = new System.Drawing.Size(105, 23);
            this.btnherramientas.TabIndex = 7;
            this.btnherramientas.Text = "HERRAMIENTAS";
            this.btnherramientas.UseVisualStyleBackColor = true;
            // 
            // btnproducto
            // 
            this.btnproducto.Location = new System.Drawing.Point(1, 41);
            this.btnproducto.Name = "btnproducto";
            this.btnproducto.Size = new System.Drawing.Size(105, 23);
            this.btnproducto.TabIndex = 6;
            this.btnproducto.Text = "PRODUCTOS";
            this.btnproducto.UseVisualStyleBackColor = true;
            // 
            // btninicio
            // 
            this.btninicio.Location = new System.Drawing.Point(1, 12);
            this.btninicio.Name = "btninicio";
            this.btninicio.Size = new System.Drawing.Size(105, 23);
            this.btninicio.TabIndex = 5;
            this.btninicio.Text = "INICIO";
            this.btninicio.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(348, 29);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(128, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "PRODUCTOS";
            // 
            // txtbuscar
            // 
            this.txtbuscar.Location = new System.Drawing.Point(3, 38);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(282, 20);
            this.txtbuscar.TabIndex = 1;
            // 
            // btnañadirp
            // 
            this.btnañadirp.Location = new System.Drawing.Point(285, 36);
            this.btnañadirp.Name = "btnañadirp";
            this.btnañadirp.Size = new System.Drawing.Size(66, 23);
            this.btnañadirp.TabIndex = 2;
            this.btnañadirp.Text = "+";
            this.btnañadirp.UseVisualStyleBackColor = true;
            // 
            // dtgproductos
            // 
            this.dtgproductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgproductos.Location = new System.Drawing.Point(3, 64);
            this.dtgproductos.Name = "dtgproductos";
            this.dtgproductos.Size = new System.Drawing.Size(348, 226);
            this.dtgproductos.TabIndex = 3;
            this.dtgproductos.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgproductos_CellEnter);
            // 
            // FrmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(478, 317);
            this.Controls.Add(this.pnlcontenido);
            this.Controls.Add(this.btnadmi);
            this.Controls.Add(this.btnherramientas);
            this.Controls.Add(this.btnproducto);
            this.Controls.Add(this.btninicio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmProductos";
            this.Text = "FrmProductos";
            this.pnlcontenido.ResumeLayout(false);
            this.pnlcontenido.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgproductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlcontenido;
        private System.Windows.Forms.Button btnadmi;
        private System.Windows.Forms.Button btnherramientas;
        private System.Windows.Forms.Button btnproducto;
        private System.Windows.Forms.Button btninicio;
        private System.Windows.Forms.DataGridView dtgproductos;
        private System.Windows.Forms.Button btnañadirp;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}