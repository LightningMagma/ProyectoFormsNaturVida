namespace CapaPresentacion
{
    partial class Producto
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.insertarProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarProdructoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlConsultar = new System.Windows.Forms.Panel();
            this.GridConsultar = new System.Windows.Forms.DataGridView();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.pnlEliminar = new System.Windows.Forms.Panel();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtEliminar = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.pnlActualizar = new System.Windows.Forms.Panel();
            this.txtCanAc = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtValorAc = new System.Windows.Forms.TextBox();
            this.txtDescAct = new System.Windows.Forms.TextBox();
            this.txtCodigoAc = new System.Windows.Forms.TextBox();
            this.btnGuardarCambios = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtActualizar = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pnlInsertarProducto = new System.Windows.Forms.Panel();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtNombrePro = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtDescipcion = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.pnlConsultar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridConsultar)).BeginInit();
            this.pnlEliminar.SuspendLayout();
            this.pnlActualizar.SuspendLayout();
            this.pnlInsertarProducto.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(898, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gestionar Productos";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightBlue;
            this.groupBox1.Controls.Add(this.menuStrip1);
            this.groupBox1.Controls.Add(this.pnlConsultar);
            this.groupBox1.Controls.Add(this.pnlEliminar);
            this.groupBox1.Controls.Add(this.pnlActualizar);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(563, 246);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(765, 353);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "--------------------------";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.insertarProductoToolStripMenuItem,
            this.consultarProductoToolStripMenuItem,
            this.actualizarProdructoToolStripMenuItem,
            this.eliminarProductoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(3, 19);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(759, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // insertarProductoToolStripMenuItem
            // 
            this.insertarProductoToolStripMenuItem.Name = "insertarProductoToolStripMenuItem";
            this.insertarProductoToolStripMenuItem.Size = new System.Drawing.Size(110, 20);
            this.insertarProductoToolStripMenuItem.Text = "Insertar Producto";
            this.insertarProductoToolStripMenuItem.Click += new System.EventHandler(this.insertarProductoToolStripMenuItem_Click);
            // 
            // consultarProductoToolStripMenuItem
            // 
            this.consultarProductoToolStripMenuItem.Name = "consultarProductoToolStripMenuItem";
            this.consultarProductoToolStripMenuItem.Size = new System.Drawing.Size(122, 20);
            this.consultarProductoToolStripMenuItem.Text = "Consultar Producto";
            this.consultarProductoToolStripMenuItem.Click += new System.EventHandler(this.consultarProductoToolStripMenuItem_Click);
            // 
            // actualizarProdructoToolStripMenuItem
            // 
            this.actualizarProdructoToolStripMenuItem.Name = "actualizarProdructoToolStripMenuItem";
            this.actualizarProdructoToolStripMenuItem.Size = new System.Drawing.Size(127, 20);
            this.actualizarProdructoToolStripMenuItem.Text = "Actualizar prodructo";
            this.actualizarProdructoToolStripMenuItem.Click += new System.EventHandler(this.actualizarProdructoToolStripMenuItem_Click);
            // 
            // eliminarProductoToolStripMenuItem
            // 
            this.eliminarProductoToolStripMenuItem.Name = "eliminarProductoToolStripMenuItem";
            this.eliminarProductoToolStripMenuItem.Size = new System.Drawing.Size(114, 20);
            this.eliminarProductoToolStripMenuItem.Text = "Eliminar producto";
            this.eliminarProductoToolStripMenuItem.Click += new System.EventHandler(this.eliminarProductoToolStripMenuItem_Click);
            // 
            // pnlConsultar
            // 
            this.pnlConsultar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlConsultar.Controls.Add(this.GridConsultar);
            this.pnlConsultar.Controls.Add(this.btnConsultar);
            this.pnlConsultar.Location = new System.Drawing.Point(0, 46);
            this.pnlConsultar.Name = "pnlConsultar";
            this.pnlConsultar.Size = new System.Drawing.Size(765, 307);
            this.pnlConsultar.TabIndex = 10;
            this.pnlConsultar.Visible = false;
            // 
            // GridConsultar
            // 
            this.GridConsultar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridConsultar.Location = new System.Drawing.Point(66, 86);
            this.GridConsultar.Name = "GridConsultar";
            this.GridConsultar.RowTemplate.Height = 25;
            this.GridConsultar.Size = new System.Drawing.Size(638, 150);
            this.GridConsultar.TabIndex = 3;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(335, 28);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 2;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // pnlEliminar
            // 
            this.pnlEliminar.Controls.Add(this.btnEliminar);
            this.pnlEliminar.Controls.Add(this.txtEliminar);
            this.pnlEliminar.Controls.Add(this.label11);
            this.pnlEliminar.Location = new System.Drawing.Point(0, 46);
            this.pnlEliminar.Name = "pnlEliminar";
            this.pnlEliminar.Size = new System.Drawing.Size(765, 307);
            this.pnlEliminar.TabIndex = 10;
            this.pnlEliminar.Visible = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(320, 169);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txtEliminar
            // 
            this.txtEliminar.FormattingEnabled = true;
            this.txtEliminar.Location = new System.Drawing.Point(371, 115);
            this.txtEliminar.Name = "txtEliminar";
            this.txtEliminar.Size = new System.Drawing.Size(121, 23);
            this.txtEliminar.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(216, 120);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 15);
            this.label11.TabIndex = 3;
            this.label11.Text = "Producto :";
            // 
            // pnlActualizar
            // 
            this.pnlActualizar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlActualizar.Controls.Add(this.txtCanAc);
            this.pnlActualizar.Controls.Add(this.label14);
            this.pnlActualizar.Controls.Add(this.txtNombre);
            this.pnlActualizar.Controls.Add(this.label12);
            this.pnlActualizar.Controls.Add(this.txtValorAc);
            this.pnlActualizar.Controls.Add(this.txtDescAct);
            this.pnlActualizar.Controls.Add(this.txtCodigoAc);
            this.pnlActualizar.Controls.Add(this.btnGuardarCambios);
            this.pnlActualizar.Controls.Add(this.label10);
            this.pnlActualizar.Controls.Add(this.label9);
            this.pnlActualizar.Controls.Add(this.label8);
            this.pnlActualizar.Controls.Add(this.btnBuscar);
            this.pnlActualizar.Controls.Add(this.txtActualizar);
            this.pnlActualizar.Controls.Add(this.label7);
            this.pnlActualizar.Location = new System.Drawing.Point(3, 46);
            this.pnlActualizar.Name = "pnlActualizar";
            this.pnlActualizar.Size = new System.Drawing.Size(765, 307);
            this.pnlActualizar.TabIndex = 4;
            this.pnlActualizar.Visible = false;
            // 
            // txtCanAc
            // 
            this.txtCanAc.Location = new System.Drawing.Point(347, 246);
            this.txtCanAc.Name = "txtCanAc";
            this.txtCanAc.Size = new System.Drawing.Size(100, 23);
            this.txtCanAc.TabIndex = 13;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(236, 252);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 15);
            this.label14.TabIndex = 12;
            this.label14.Text = "Cantidad";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(347, 138);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 23);
            this.txtNombre.TabIndex = 11;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(236, 143);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 15);
            this.label12.TabIndex = 10;
            this.label12.Text = "Nombre";
            // 
            // txtValorAc
            // 
            this.txtValorAc.Location = new System.Drawing.Point(346, 211);
            this.txtValorAc.Name = "txtValorAc";
            this.txtValorAc.Size = new System.Drawing.Size(100, 23);
            this.txtValorAc.TabIndex = 9;
            // 
            // txtDescAct
            // 
            this.txtDescAct.Location = new System.Drawing.Point(346, 174);
            this.txtDescAct.Name = "txtDescAct";
            this.txtDescAct.Size = new System.Drawing.Size(100, 23);
            this.txtDescAct.TabIndex = 8;
            // 
            // txtCodigoAc
            // 
            this.txtCodigoAc.Location = new System.Drawing.Point(346, 105);
            this.txtCodigoAc.Name = "txtCodigoAc";
            this.txtCodigoAc.Size = new System.Drawing.Size(100, 23);
            this.txtCodigoAc.TabIndex = 7;
            // 
            // btnGuardarCambios
            // 
            this.btnGuardarCambios.Location = new System.Drawing.Point(332, 273);
            this.btnGuardarCambios.Name = "btnGuardarCambios";
            this.btnGuardarCambios.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarCambios.TabIndex = 6;
            this.btnGuardarCambios.Text = "Guardar Cambios";
            this.btnGuardarCambios.UseVisualStyleBackColor = true;
            this.btnGuardarCambios.Click += new System.EventHandler(this.btnGuardarCambios_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(235, 219);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 15);
            this.label10.TabIndex = 5;
            this.label10.Text = "Valor";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(235, 177);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 15);
            this.label9.TabIndex = 4;
            this.label9.Text = "Descripcion";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(235, 108);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 15);
            this.label8.TabIndex = 3;
            this.label8.Text = "Codigo";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(332, 69);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtActualizar
            // 
            this.txtActualizar.FormattingEnabled = true;
            this.txtActualizar.Location = new System.Drawing.Point(383, 32);
            this.txtActualizar.Name = "txtActualizar";
            this.txtActualizar.Size = new System.Drawing.Size(121, 23);
            this.txtActualizar.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(228, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "Producto :";
            // 
            // pnlInsertarProducto
            // 
            this.pnlInsertarProducto.BackColor = System.Drawing.Color.LightBlue;
            this.pnlInsertarProducto.Controls.Add(this.txtCodigo);
            this.pnlInsertarProducto.Controls.Add(this.label13);
            this.pnlInsertarProducto.Controls.Add(this.txtNombrePro);
            this.pnlInsertarProducto.Controls.Add(this.txtCantidad);
            this.pnlInsertarProducto.Controls.Add(this.txtValor);
            this.pnlInsertarProducto.Controls.Add(this.txtDescipcion);
            this.pnlInsertarProducto.Controls.Add(this.btnLimpiar);
            this.pnlInsertarProducto.Controls.Add(this.btnGuardar);
            this.pnlInsertarProducto.Controls.Add(this.label5);
            this.pnlInsertarProducto.Controls.Add(this.label4);
            this.pnlInsertarProducto.Controls.Add(this.label3);
            this.pnlInsertarProducto.Controls.Add(this.label2);
            this.pnlInsertarProducto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlInsertarProducto.Location = new System.Drawing.Point(563, 292);
            this.pnlInsertarProducto.Name = "pnlInsertarProducto";
            this.pnlInsertarProducto.Size = new System.Drawing.Size(765, 307);
            this.pnlInsertarProducto.TabIndex = 1;
            this.pnlInsertarProducto.Visible = false;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(374, 57);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 23);
            this.txtCodigo.TabIndex = 12;
            this.txtCodigo.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(229, 93);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 15);
            this.label13.TabIndex = 11;
            this.label13.Text = "Nombre";
            // 
            // txtNombrePro
            // 
            this.txtNombrePro.Location = new System.Drawing.Point(373, 90);
            this.txtNombrePro.Name = "txtNombrePro";
            this.txtNombrePro.Size = new System.Drawing.Size(100, 23);
            this.txtNombrePro.TabIndex = 10;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(373, 185);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 23);
            this.txtCantidad.TabIndex = 9;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(373, 156);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 23);
            this.txtValor.TabIndex = 8;
            // 
            // txtDescipcion
            // 
            this.txtDescipcion.Location = new System.Drawing.Point(373, 123);
            this.txtDescipcion.Name = "txtDescipcion";
            this.txtDescipcion.Size = new System.Drawing.Size(100, 23);
            this.txtDescipcion.TabIndex = 7;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(389, 227);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 5;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(246, 227);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(229, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "Cantidad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(229, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Valor :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(229, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Descripción :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(229, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Codigo:";
            // 
            // Producto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1680, 841);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlInsertarProducto);
            this.Controls.Add(this.groupBox1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Producto";
            this.Text = "Producto";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Producto_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlConsultar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridConsultar)).EndInit();
            this.pnlEliminar.ResumeLayout(false);
            this.pnlEliminar.PerformLayout();
            this.pnlActualizar.ResumeLayout(false);
            this.pnlActualizar.PerformLayout();
            this.pnlInsertarProducto.ResumeLayout(false);
            this.pnlInsertarProducto.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem insertarProductoToolStripMenuItem;
        private ToolStripMenuItem consultarProductoToolStripMenuItem;
        private ToolStripMenuItem actualizarProdructoToolStripMenuItem;
        private ToolStripMenuItem eliminarProductoToolStripMenuItem;
        private Panel pnlConsultar;
        private Button btnConsultar;
        private Panel pnlInsertarProducto;
        private Panel pnlActualizar;
        private TextBox txtValorAc;
        private TextBox txtDescAct;
        private TextBox txtCodigoAc;
        private Button btnGuardarCambios;
        private Label label10;
        private Label label9;
        private Label label8;
        private Button btnBuscar;
        private ComboBox txtActualizar;
        private Label label7;
        private TextBox txtCantidad;
        private TextBox txtValor;
        private TextBox txtDescipcion;
        private Button btnLimpiar;
        private Button btnGuardar;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Panel pnlEliminar;
        private Button btnEliminar;
        private ComboBox txtEliminar;
        private Label label11;
        private Label label13;
        private TextBox txtNombrePro;
        private TextBox txtNombre;
        private Label label12;
        private TextBox txtCodigo;
        private DataGridView GridConsultar;
        private TextBox txtCanAc;
        private Label label14;
    }
}