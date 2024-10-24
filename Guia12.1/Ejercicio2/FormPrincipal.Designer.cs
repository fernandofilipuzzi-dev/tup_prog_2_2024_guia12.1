namespace Ejercicio2
{
    partial class FormPrincipal
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbMotivo = new System.Windows.Forms.TextBox();
            this.tbNombrePersona = new System.Windows.Forms.TextBox();
            this.btnRegistrarReclamo = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbxVerReclamos = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbxVerOrdensAEjecutar = new System.Windows.Forms.ListBox();
            this.btnEjecutarOrden = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbMotivo);
            this.groupBox1.Controls.Add(this.tbNombrePersona);
            this.groupBox1.Controls.Add(this.btnRegistrarReclamo);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(315, 297);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Recepción de reclamos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 38);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Datos del reclamo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 111);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Motivo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 71);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre";
            // 
            // tbMotivo
            // 
            this.tbMotivo.Location = new System.Drawing.Point(84, 108);
            this.tbMotivo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbMotivo.Multiline = true;
            this.tbMotivo.Name = "tbMotivo";
            this.tbMotivo.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbMotivo.Size = new System.Drawing.Size(211, 100);
            this.tbMotivo.TabIndex = 2;
            // 
            // tbNombrePersona
            // 
            this.tbNombrePersona.Location = new System.Drawing.Point(84, 68);
            this.tbNombrePersona.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbNombrePersona.Name = "tbNombrePersona";
            this.tbNombrePersona.Size = new System.Drawing.Size(211, 26);
            this.tbNombrePersona.TabIndex = 1;
            // 
            // btnRegistrarReclamo
            // 
            this.btnRegistrarReclamo.Location = new System.Drawing.Point(101, 225);
            this.btnRegistrarReclamo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRegistrarReclamo.Name = "btnRegistrarReclamo";
            this.btnRegistrarReclamo.Size = new System.Drawing.Size(147, 62);
            this.btnRegistrarReclamo.TabIndex = 0;
            this.btnRegistrarReclamo.Text = "Registrar Reclamo";
            this.btnRegistrarReclamo.UseVisualStyleBackColor = true;
            this.btnRegistrarReclamo.Click += new System.EventHandler(this.btnRegistrarReclamo_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.lbxVerReclamos);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Location = new System.Drawing.Point(336, 15);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(244, 295);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Planificar Trabajo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 36);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Lista de reclamos";
            // 
            // lbxVerReclamos
            // 
            this.lbxVerReclamos.FormattingEnabled = true;
            this.lbxVerReclamos.ItemHeight = 20;
            this.lbxVerReclamos.Location = new System.Drawing.Point(18, 69);
            this.lbxVerReclamos.Name = "lbxVerReclamos";
            this.lbxVerReclamos.Size = new System.Drawing.Size(213, 144);
            this.lbxVerReclamos.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(54, 228);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 57);
            this.button2.TabIndex = 1;
            this.button2.Text = "Crear Orden De Trabajo";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnResolverReclamo_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.lbxVerOrdensAEjecutar);
            this.groupBox3.Controls.Add(this.btnEjecutarOrden);
            this.groupBox3.Location = new System.Drawing.Point(588, 15);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(250, 295);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ordenes de trabajos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 36);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Trabajos ejecutados";
            // 
            // lbxVerOrdensAEjecutar
            // 
            this.lbxVerOrdensAEjecutar.FormattingEnabled = true;
            this.lbxVerOrdensAEjecutar.ItemHeight = 20;
            this.lbxVerOrdensAEjecutar.Location = new System.Drawing.Point(7, 69);
            this.lbxVerOrdensAEjecutar.Name = "lbxVerOrdensAEjecutar";
            this.lbxVerOrdensAEjecutar.Size = new System.Drawing.Size(235, 144);
            this.lbxVerOrdensAEjecutar.TabIndex = 3;
            // 
            // btnEjecutarOrden
            // 
            this.btnEjecutarOrden.Location = new System.Drawing.Point(61, 227);
            this.btnEjecutarOrden.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEjecutarOrden.Name = "btnEjecutarOrden";
            this.btnEjecutarOrden.Size = new System.Drawing.Size(136, 58);
            this.btnEjecutarOrden.TabIndex = 2;
            this.btnEjecutarOrden.Text = "Ejecutar Orden de Trabajo";
            this.btnEjecutarOrden.UseVisualStyleBackColor = true;
            this.btnEjecutarOrden.Click += new System.EventHandler(this.btnEjecutarOrden_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 312);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPrincipal";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRegistrarReclamo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbMotivo;
        private System.Windows.Forms.TextBox tbNombrePersona;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnEjecutarOrden;
        private System.Windows.Forms.ListBox lbxVerReclamos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lbxVerOrdensAEjecutar;
    }
}

