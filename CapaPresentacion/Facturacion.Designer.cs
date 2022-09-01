namespace CapaPresentacion
{
    partial class Facturacion
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtCliente = new System.Windows.Forms.ComboBox();
            this.txtProducto = new System.Windows.Forms.ComboBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.btnTerminarFactura = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.DateTimePicker();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.txtTotalFactura = new System.Windows.Forms.TextBox();
            this.GridFactura = new System.Windows.Forms.DataGridView();
            this.idColumna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.facNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.facProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.facCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnActualizarfactura = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridFactura)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(613, 250);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(615, 289);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(615, 327);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Producto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(615, 364);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cantidad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1056, 611);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Total factura";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(684, 247);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(290, 23);
            this.txtCodigo.TabIndex = 5;
            // 
            // txtCliente
            // 
            this.txtCliente.FormattingEnabled = true;
            this.txtCliente.Location = new System.Drawing.Point(684, 286);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(290, 23);
            this.txtCliente.TabIndex = 6;
            // 
            // txtProducto
            // 
            this.txtProducto.FormattingEnabled = true;
            this.txtProducto.Location = new System.Drawing.Point(684, 327);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(290, 23);
            this.txtProducto.TabIndex = 7;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(684, 361);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 23);
            this.txtCantidad.TabIndex = 8;
            // 
            // btnTerminarFactura
            // 
            this.btnTerminarFactura.Location = new System.Drawing.Point(662, 607);
            this.btnTerminarFactura.Name = "btnTerminarFactura";
            this.btnTerminarFactura.Size = new System.Drawing.Size(178, 23);
            this.btnTerminarFactura.TabIndex = 9;
            this.btnTerminarFactura.Text = "Terminar Factura";
            this.btnTerminarFactura.UseVisualStyleBackColor = true;
            this.btnTerminarFactura.Click += new System.EventHandler(this.btnTerminarFactura_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(989, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Fecha";
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(1033, 250);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(200, 23);
            this.txtFecha.TabIndex = 11;
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.Location = new System.Drawing.Point(1056, 327);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(144, 23);
            this.btnAgregarProducto.TabIndex = 12;
            this.btnAgregarProducto.Text = "Agregar Producto";
            this.btnAgregarProducto.UseVisualStyleBackColor = true;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // txtTotalFactura
            // 
            this.txtTotalFactura.Location = new System.Drawing.Point(1158, 608);
            this.txtTotalFactura.Name = "txtTotalFactura";
            this.txtTotalFactura.ReadOnly = true;
            this.txtTotalFactura.Size = new System.Drawing.Size(100, 23);
            this.txtTotalFactura.TabIndex = 13;
            // 
            // GridFactura
            // 
            this.GridFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridFactura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idColumna,
            this.facNumero,
            this.facProducto,
            this.facCantidad,
            this.proValor});
            this.GridFactura.Location = new System.Drawing.Point(613, 402);
            this.GridFactura.Name = "GridFactura";
            this.GridFactura.RowTemplate.Height = 25;
            this.GridFactura.Size = new System.Drawing.Size(707, 186);
            this.GridFactura.TabIndex = 14;
            // 
            // idColumna
            // 
            this.idColumna.HeaderText = "idFactura";
            this.idColumna.Name = "idColumna";
            // 
            // facNumero
            // 
            this.facNumero.HeaderText = "Numero Factura";
            this.facNumero.Name = "facNumero";
            // 
            // facProducto
            // 
            this.facProducto.HeaderText = "ProductoFactura";
            this.facProducto.Name = "facProducto";
            // 
            // facCantidad
            // 
            this.facCantidad.HeaderText = "Cantidad";
            this.facCantidad.Name = "facCantidad";
            // 
            // proValor
            // 
            this.proValor.HeaderText = "Valor unitario";
            this.proValor.Name = "proValor";
            // 
            // btnActualizarfactura
            // 
            this.btnActualizarfactura.Location = new System.Drawing.Point(1056, 364);
            this.btnActualizarfactura.Name = "btnActualizarfactura";
            this.btnActualizarfactura.Size = new System.Drawing.Size(144, 23);
            this.btnActualizarfactura.TabIndex = 15;
            this.btnActualizarfactura.Text = "Actualizar factura";
            this.btnActualizarfactura.UseVisualStyleBackColor = true;
            this.btnActualizarfactura.Click += new System.EventHandler(this.btnActualizarfactura_Click);
            // 
            // Facturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1674, 851);
            this.Controls.Add(this.btnActualizarfactura);
            this.Controls.Add(this.GridFactura);
            this.Controls.Add(this.txtTotalFactura);
            this.Controls.Add(this.btnAgregarProducto);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnTerminarFactura);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtProducto);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Facturacion";
            this.Text = "Formulario";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Facturacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridFactura)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtCodigo;
        private ComboBox txtCliente;
        private ComboBox txtProducto;
        private TextBox txtCantidad;
        private Button btnTerminarFactura;
        private Label label6;
        private DateTimePicker txtFecha;
        private Button btnAgregarProducto;
        private TextBox txtTotalFactura;
        private DataGridView GridFactura;
        private Button btnActualizarfactura;
        private DataGridViewTextBoxColumn idColumna;
        private DataGridViewTextBoxColumn facNumero;
        private DataGridViewTextBoxColumn facProducto;
        private DataGridViewTextBoxColumn facCantidad;
        private DataGridViewTextBoxColumn proValor;
    }
}