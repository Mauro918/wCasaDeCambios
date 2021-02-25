namespace wCasaDeCambios
{
    partial class frmCasaCambio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpDatosPersonales = new System.Windows.Forms.GroupBox();
            this.cmbCiuda = new System.Windows.Forms.ComboBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblCiudad = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.grpTipoDeMoneda = new System.Windows.Forms.GroupBox();
            this.rdoBTC = new System.Windows.Forms.RadioButton();
            this.rdoCheque = new System.Windows.Forms.RadioButton();
            this.rdoTransferencia = new System.Windows.Forms.RadioButton();
            this.rdoEfectivo = new System.Windows.Forms.RadioButton();
            this.cmbMonedaDestino = new System.Windows.Forms.ComboBox();
            this.cmbMonedaOrigen = new System.Windows.Forms.ComboBox();
            this.lblMonedaDestino = new System.Windows.Forms.Label();
            this.lblMonedaOrigen = new System.Windows.Forms.Label();
            this.grpConversion = new System.Windows.Forms.GroupBox();
            this.lblCantidadValorCambiar = new System.Windows.Forms.Label();
            this.lblValorCanje = new System.Windows.Forms.Label();
            this.btnCambiar = new System.Windows.Forms.Button();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtCantidadValorCambio = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.smnuSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.grpDatosPersonales.SuspendLayout();
            this.grpTipoDeMoneda.SuspendLayout();
            this.grpConversion.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDatosPersonales
            // 
            this.grpDatosPersonales.Controls.Add(this.cmbCiuda);
            this.grpDatosPersonales.Controls.Add(this.txtTelefono);
            this.grpDatosPersonales.Controls.Add(this.txtApellido);
            this.grpDatosPersonales.Controls.Add(this.txtDireccion);
            this.grpDatosPersonales.Controls.Add(this.txtNombre);
            this.grpDatosPersonales.Controls.Add(this.lblTelefono);
            this.grpDatosPersonales.Controls.Add(this.lblApellido);
            this.grpDatosPersonales.Controls.Add(this.lblCiudad);
            this.grpDatosPersonales.Controls.Add(this.lblDireccion);
            this.grpDatosPersonales.Controls.Add(this.lblNombre);
            this.grpDatosPersonales.Location = new System.Drawing.Point(73, 35);
            this.grpDatosPersonales.Name = "grpDatosPersonales";
            this.grpDatosPersonales.Size = new System.Drawing.Size(649, 156);
            this.grpDatosPersonales.TabIndex = 0;
            this.grpDatosPersonales.TabStop = false;
            this.grpDatosPersonales.Text = "Datos Personales";
            // 
            // cmbCiuda
            // 
            this.cmbCiuda.FormattingEnabled = true;
            this.cmbCiuda.Location = new System.Drawing.Point(76, 110);
            this.cmbCiuda.Name = "cmbCiuda";
            this.cmbCiuda.Size = new System.Drawing.Size(121, 21);
            this.cmbCiuda.TabIndex = 7;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(418, 61);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(100, 20);
            this.txtTelefono.TabIndex = 6;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(418, 29);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 20);
            this.txtApellido.TabIndex = 5;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(76, 68);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(100, 20);
            this.txtDireccion.TabIndex = 5;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(76, 32);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 4;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(363, 68);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(49, 13);
            this.lblTelefono.TabIndex = 3;
            this.lblTelefono.Text = "Telefono";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(363, 32);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 1;
            this.lblApellido.Text = "Apellido";
            // 
            // lblCiudad
            // 
            this.lblCiudad.AutoSize = true;
            this.lblCiudad.Location = new System.Drawing.Point(18, 110);
            this.lblCiudad.Name = "lblCiudad";
            this.lblCiudad.Size = new System.Drawing.Size(40, 13);
            this.lblCiudad.TabIndex = 2;
            this.lblCiudad.Text = "Ciudad";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(18, 68);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(52, 13);
            this.lblDireccion.TabIndex = 1;
            this.lblDireccion.Text = "Direccion";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(18, 32);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // grpTipoDeMoneda
            // 
            this.grpTipoDeMoneda.Controls.Add(this.rdoBTC);
            this.grpTipoDeMoneda.Controls.Add(this.rdoCheque);
            this.grpTipoDeMoneda.Controls.Add(this.rdoTransferencia);
            this.grpTipoDeMoneda.Controls.Add(this.rdoEfectivo);
            this.grpTipoDeMoneda.Controls.Add(this.cmbMonedaDestino);
            this.grpTipoDeMoneda.Controls.Add(this.cmbMonedaOrigen);
            this.grpTipoDeMoneda.Controls.Add(this.lblMonedaDestino);
            this.grpTipoDeMoneda.Controls.Add(this.lblMonedaOrigen);
            this.grpTipoDeMoneda.Location = new System.Drawing.Point(73, 197);
            this.grpTipoDeMoneda.Name = "grpTipoDeMoneda";
            this.grpTipoDeMoneda.Size = new System.Drawing.Size(292, 171);
            this.grpTipoDeMoneda.TabIndex = 1;
            this.grpTipoDeMoneda.TabStop = false;
            this.grpTipoDeMoneda.Text = "Tipo De Moneda";
            // 
            // rdoBTC
            // 
            this.rdoBTC.AutoSize = true;
            this.rdoBTC.Location = new System.Drawing.Point(147, 133);
            this.rdoBTC.Name = "rdoBTC";
            this.rdoBTC.Size = new System.Drawing.Size(46, 17);
            this.rdoBTC.TabIndex = 13;
            this.rdoBTC.TabStop = true;
            this.rdoBTC.Text = "BTC";
            this.rdoBTC.UseVisualStyleBackColor = true;
            // 
            // rdoCheque
            // 
            this.rdoCheque.AutoSize = true;
            this.rdoCheque.Location = new System.Drawing.Point(63, 133);
            this.rdoCheque.Name = "rdoCheque";
            this.rdoCheque.Size = new System.Drawing.Size(62, 17);
            this.rdoCheque.TabIndex = 12;
            this.rdoCheque.TabStop = true;
            this.rdoCheque.Text = "Cheque";
            this.rdoCheque.UseVisualStyleBackColor = true;
            // 
            // rdoTransferencia
            // 
            this.rdoTransferencia.AutoSize = true;
            this.rdoTransferencia.Location = new System.Drawing.Point(147, 110);
            this.rdoTransferencia.Name = "rdoTransferencia";
            this.rdoTransferencia.Size = new System.Drawing.Size(84, 17);
            this.rdoTransferencia.TabIndex = 11;
            this.rdoTransferencia.TabStop = true;
            this.rdoTransferencia.Text = "Trasferencia";
            this.rdoTransferencia.UseVisualStyleBackColor = true;
            // 
            // rdoEfectivo
            // 
            this.rdoEfectivo.AutoSize = true;
            this.rdoEfectivo.Location = new System.Drawing.Point(63, 110);
            this.rdoEfectivo.Name = "rdoEfectivo";
            this.rdoEfectivo.Size = new System.Drawing.Size(64, 17);
            this.rdoEfectivo.TabIndex = 10;
            this.rdoEfectivo.TabStop = true;
            this.rdoEfectivo.Text = "Efectivo";
            this.rdoEfectivo.UseVisualStyleBackColor = true;
            // 
            // cmbMonedaDestino
            // 
            this.cmbMonedaDestino.FormattingEnabled = true;
            this.cmbMonedaDestino.Location = new System.Drawing.Point(124, 73);
            this.cmbMonedaDestino.Name = "cmbMonedaDestino";
            this.cmbMonedaDestino.Size = new System.Drawing.Size(121, 21);
            this.cmbMonedaDestino.TabIndex = 9;
            // 
            // cmbMonedaOrigen
            // 
            this.cmbMonedaOrigen.FormattingEnabled = true;
            this.cmbMonedaOrigen.Location = new System.Drawing.Point(124, 38);
            this.cmbMonedaOrigen.Name = "cmbMonedaOrigen";
            this.cmbMonedaOrigen.Size = new System.Drawing.Size(121, 21);
            this.cmbMonedaOrigen.TabIndex = 8;
            // 
            // lblMonedaDestino
            // 
            this.lblMonedaDestino.AutoSize = true;
            this.lblMonedaDestino.Location = new System.Drawing.Point(18, 73);
            this.lblMonedaDestino.Name = "lblMonedaDestino";
            this.lblMonedaDestino.Size = new System.Drawing.Size(85, 13);
            this.lblMonedaDestino.TabIndex = 1;
            this.lblMonedaDestino.Text = "Moneda Destino";
            // 
            // lblMonedaOrigen
            // 
            this.lblMonedaOrigen.AutoSize = true;
            this.lblMonedaOrigen.Location = new System.Drawing.Point(18, 38);
            this.lblMonedaOrigen.Name = "lblMonedaOrigen";
            this.lblMonedaOrigen.Size = new System.Drawing.Size(80, 13);
            this.lblMonedaOrigen.TabIndex = 0;
            this.lblMonedaOrigen.Text = "Moneda Origen";
            // 
            // grpConversion
            // 
            this.grpConversion.Controls.Add(this.lblCantidadValorCambiar);
            this.grpConversion.Controls.Add(this.lblValorCanje);
            this.grpConversion.Controls.Add(this.btnCambiar);
            this.grpConversion.Controls.Add(this.txtValor);
            this.grpConversion.Controls.Add(this.txtCantidadValorCambio);
            this.grpConversion.Location = new System.Drawing.Point(418, 197);
            this.grpConversion.Name = "grpConversion";
            this.grpConversion.Size = new System.Drawing.Size(304, 171);
            this.grpConversion.TabIndex = 2;
            this.grpConversion.TabStop = false;
            this.grpConversion.Text = "Conversion";
            // 
            // lblCantidadValorCambiar
            // 
            this.lblCantidadValorCambiar.AutoSize = true;
            this.lblCantidadValorCambiar.Location = new System.Drawing.Point(18, 70);
            this.lblCantidadValorCambiar.Name = "lblCantidadValorCambiar";
            this.lblCantidadValorCambiar.Size = new System.Drawing.Size(125, 13);
            this.lblCantidadValorCambiar.TabIndex = 10;
            this.lblCantidadValorCambiar.Text = "Cantidad Valor a cambiar";
            // 
            // lblValorCanje
            // 
            this.lblValorCanje.AutoSize = true;
            this.lblValorCanje.Location = new System.Drawing.Point(18, 38);
            this.lblValorCanje.Name = "lblValorCanje";
            this.lblValorCanje.Size = new System.Drawing.Size(78, 13);
            this.lblValorCanje.TabIndex = 9;
            this.lblValorCanje.Text = "Valor del Canje";
            // 
            // btnCambiar
            // 
            this.btnCambiar.Location = new System.Drawing.Point(98, 127);
            this.btnCambiar.Name = "btnCambiar";
            this.btnCambiar.Size = new System.Drawing.Size(75, 23);
            this.btnCambiar.TabIndex = 8;
            this.btnCambiar.Text = "Cambiar";
            this.btnCambiar.UseVisualStyleBackColor = true;
            this.btnCambiar.Click += new System.EventHandler(this.btnCambiar_Click);
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(160, 31);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 20);
            this.txtValor.TabIndex = 7;
            // 
            // txtCantidadValorCambio
            // 
            this.txtCantidadValorCambio.Location = new System.Drawing.Point(160, 63);
            this.txtCantidadValorCambio.Name = "txtCantidadValorCambio";
            this.txtCantidadValorCambio.Size = new System.Drawing.Size(100, 20);
            this.txtCantidadValorCambio.TabIndex = 6;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(355, 405);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(811, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smnuSalir});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "&Archivo";
            // 
            // smnuSalir
            // 
            this.smnuSalir.Name = "smnuSalir";
            this.smnuSalir.Size = new System.Drawing.Size(96, 22);
            this.smnuSalir.Text = "&Salir";
            this.smnuSalir.Click += new System.EventHandler(this.smnuSalir_Click);
            // 
            // frmCasaCambio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 464);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.grpConversion);
            this.Controls.Add(this.grpTipoDeMoneda);
            this.Controls.Add(this.grpDatosPersonales);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmCasaCambio";
            this.Text = "Casa De Cambio";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCasaCambio_FormClosing);
            this.grpDatosPersonales.ResumeLayout(false);
            this.grpDatosPersonales.PerformLayout();
            this.grpTipoDeMoneda.ResumeLayout(false);
            this.grpTipoDeMoneda.PerformLayout();
            this.grpConversion.ResumeLayout(false);
            this.grpConversion.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDatosPersonales;
        private System.Windows.Forms.ComboBox cmbCiuda;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblCiudad;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.GroupBox grpTipoDeMoneda;
        private System.Windows.Forms.RadioButton rdoBTC;
        private System.Windows.Forms.RadioButton rdoCheque;
        private System.Windows.Forms.RadioButton rdoTransferencia;
        private System.Windows.Forms.RadioButton rdoEfectivo;
        private System.Windows.Forms.ComboBox cmbMonedaDestino;
        private System.Windows.Forms.ComboBox cmbMonedaOrigen;
        private System.Windows.Forms.Label lblMonedaDestino;
        private System.Windows.Forms.Label lblMonedaOrigen;
        private System.Windows.Forms.GroupBox grpConversion;
        private System.Windows.Forms.Button btnCambiar;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtCantidadValorCambio;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem smnuSalir;
        private System.Windows.Forms.Label lblCantidadValorCambiar;
        private System.Windows.Forms.Label lblValorCanje;
    }
}

