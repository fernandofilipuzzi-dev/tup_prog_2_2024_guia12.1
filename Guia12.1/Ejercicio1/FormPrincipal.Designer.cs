namespace Ejercicio1
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPreparar = new System.Windows.Forms.Button();
            this.btnRecibir = new System.Windows.Forms.Button();
            this.gbDeposito = new System.Windows.Forms.GroupBox();
            this.lbxVerSectorCarga = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbDireccion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbDNI = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnIniciarReparto = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbDireccion = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbDNI = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbxListadoAEntregar = new System.Windows.Forms.ListBox();
            this.btnReparto = new System.Windows.Forms.Button();
            this.gbDeposito.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPreparar
            // 
            this.btnPreparar.Location = new System.Drawing.Point(63, 285);
            this.btnPreparar.Name = "btnPreparar";
            this.btnPreparar.Size = new System.Drawing.Size(143, 63);
            this.btnPreparar.TabIndex = 6;
            this.btnPreparar.Text = "Preparar camión";
            this.btnPreparar.UseVisualStyleBackColor = true;
            this.btnPreparar.Click += new System.EventHandler(this.btnPreparar_Click);
            // 
            // btnRecibir
            // 
            this.btnRecibir.Location = new System.Drawing.Point(57, 283);
            this.btnRecibir.Name = "btnRecibir";
            this.btnRecibir.Size = new System.Drawing.Size(164, 63);
            this.btnRecibir.TabIndex = 4;
            this.btnRecibir.Text = "Recibir Correspondencia";
            this.btnRecibir.UseVisualStyleBackColor = true;
            this.btnRecibir.Click += new System.EventHandler(this.btnRecibir_Click);
            // 
            // gbDeposito
            // 
            this.gbDeposito.Controls.Add(this.lbxVerSectorCarga);
            this.gbDeposito.Controls.Add(this.btnPreparar);
            this.gbDeposito.Location = new System.Drawing.Point(272, 4);
            this.gbDeposito.Name = "gbDeposito";
            this.gbDeposito.Size = new System.Drawing.Size(289, 356);
            this.gbDeposito.TabIndex = 18;
            this.gbDeposito.TabStop = false;
            this.gbDeposito.Text = "Paquetes en el Sector de embarque";
            // 
            // lbxVerSectorCarga
            // 
            this.lbxVerSectorCarga.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxVerSectorCarga.FormattingEnabled = true;
            this.lbxVerSectorCarga.ItemHeight = 16;
            this.lbxVerSectorCarga.Location = new System.Drawing.Point(15, 35);
            this.lbxVerSectorCarga.Name = "lbxVerSectorCarga";
            this.lbxVerSectorCarga.Size = new System.Drawing.Size(255, 244);
            this.lbxVerSectorCarga.TabIndex = 21;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbNombre);
            this.groupBox1.Controls.Add(this.tbDireccion);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbDNI);
            this.groupBox1.Controls.Add(this.btnRecibir);
            this.groupBox1.Location = new System.Drawing.Point(12, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(254, 356);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sector de atención al cliente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 26;
            this.label4.Text = "Nombre";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(96, 104);
            this.tbNombre.Multiline = true;
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(144, 57);
            this.tbNombre.TabIndex = 2;
            // 
            // tbDireccion
            // 
            this.tbDireccion.Location = new System.Drawing.Point(96, 171);
            this.tbDireccion.Multiline = true;
            this.tbDireccion.Name = "tbDireccion";
            this.tbDireccion.Size = new System.Drawing.Size(144, 87);
            this.tbDireccion.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 20);
            this.label5.TabIndex = 23;
            this.label5.Text = "Direccion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "DNI";
            // 
            // tbDNI
            // 
            this.tbDNI.Location = new System.Drawing.Point(96, 72);
            this.tbDNI.Name = "tbDNI";
            this.tbDNI.Size = new System.Drawing.Size(144, 26);
            this.tbDNI.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnIniciarReparto);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.lbxListadoAEntregar);
            this.groupBox2.Controls.Add(this.btnReparto);
            this.groupBox2.Location = new System.Drawing.Point(567, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(266, 356);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tarea de reparto";
            // 
            // btnIniciarReparto
            // 
            this.btnIniciarReparto.Location = new System.Drawing.Point(20, 145);
            this.btnIniciarReparto.Name = "btnIniciarReparto";
            this.btnIniciarReparto.Size = new System.Drawing.Size(108, 55);
            this.btnIniciarReparto.TabIndex = 30;
            this.btnIniciarReparto.Text = "Iniciar Reparto";
            this.btnIniciarReparto.UseVisualStyleBackColor = true;
            this.btnIniciarReparto.Click += new System.EventHandler(this.btnIniciarReparto_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(2, 219);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(138, 20);
            this.label8.TabIndex = 29;
            this.label8.Text = "Listado a entregar";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbDireccion);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.lbDNI);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.lbNombre);
            this.groupBox3.Location = new System.Drawing.Point(20, 25);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(240, 114);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Próximo a entregar";
            // 
            // lbDireccion
            // 
            this.lbDireccion.AutoSize = true;
            this.lbDireccion.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lbDireccion.Location = new System.Drawing.Point(89, 77);
            this.lbDireccion.Name = "lbDireccion";
            this.lbDireccion.Size = new System.Drawing.Size(77, 20);
            this.lbDireccion.TabIndex = 21;
            this.lbDireccion.Text = "                 ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-4, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 27;
            this.label3.Text = "Direccion";
            // 
            // lbDNI
            // 
            this.lbDNI.AutoSize = true;
            this.lbDNI.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lbDNI.Location = new System.Drawing.Point(89, 22);
            this.lbDNI.Name = "lbDNI";
            this.lbDNI.Size = new System.Drawing.Size(77, 20);
            this.lbDNI.TabIndex = 18;
            this.lbDNI.Text = "                 ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 20);
            this.label6.TabIndex = 28;
            this.label6.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "DNI";
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lbNombre.Location = new System.Drawing.Point(89, 47);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(77, 20);
            this.lbNombre.TabIndex = 19;
            this.lbNombre.Text = "                 ";
            // 
            // lbxListadoAEntregar
            // 
            this.lbxListadoAEntregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxListadoAEntregar.FormattingEnabled = true;
            this.lbxListadoAEntregar.ItemHeight = 16;
            this.lbxListadoAEntregar.Location = new System.Drawing.Point(6, 242);
            this.lbxListadoAEntregar.Name = "lbxListadoAEntregar";
            this.lbxListadoAEntregar.Size = new System.Drawing.Size(254, 100);
            this.lbxListadoAEntregar.TabIndex = 9;
            // 
            // btnReparto
            // 
            this.btnReparto.Enabled = false;
            this.btnReparto.Location = new System.Drawing.Point(144, 145);
            this.btnReparto.Name = "btnReparto";
            this.btnReparto.Size = new System.Drawing.Size(114, 55);
            this.btnReparto.TabIndex = 7;
            this.btnReparto.Text = "Entregar paquete";
            this.btnReparto.UseVisualStyleBackColor = true;
            this.btnReparto.Click += new System.EventHandler(this.btnReparto_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 363);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbDeposito);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ejercicio 1";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.gbDeposito.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnPreparar;
        private System.Windows.Forms.Button btnRecibir;
        private System.Windows.Forms.GroupBox gbDeposito;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbDNI;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnReparto;
        private System.Windows.Forms.TextBox tbDireccion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbDNI;
        private System.Windows.Forms.ListBox lbxListadoAEntregar;
        private System.Windows.Forms.ListBox lbxVerSectorCarga;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label lbDireccion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnIniciarReparto;
    }
}

