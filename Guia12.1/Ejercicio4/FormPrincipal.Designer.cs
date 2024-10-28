namespace Ejercicio4
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
            this.btnVerTodosNodos = new System.Windows.Forms.Button();
            this.tbVer = new System.Windows.Forms.TextBox();
            this.cbxDesde = new System.Windows.Forms.ComboBox();
            this.cbxHasta = new System.Windows.Forms.ComboBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbHijoDadoAncestro = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnVerTodosNodos
            // 
            this.btnVerTodosNodos.Location = new System.Drawing.Point(297, 12);
            this.btnVerTodosNodos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnVerTodosNodos.Name = "btnVerTodosNodos";
            this.btnVerTodosNodos.Size = new System.Drawing.Size(316, 45);
            this.btnVerTodosNodos.TabIndex = 0;
            this.btnVerTodosNodos.Text = "Mostrar Todos los Nodos";
            this.btnVerTodosNodos.UseVisualStyleBackColor = true;
            this.btnVerTodosNodos.Click += new System.EventHandler(this.btnVerTodosNodos_Click);
            // 
            // tbVer
            // 
            this.tbVer.Location = new System.Drawing.Point(12, 12);
            this.tbVer.Multiline = true;
            this.tbVer.Name = "tbVer";
            this.tbVer.ReadOnly = true;
            this.tbVer.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbVer.Size = new System.Drawing.Size(265, 268);
            this.tbVer.TabIndex = 1;
            // 
            // cbxDesde
            // 
            this.cbxDesde.FormattingEnabled = true;
            this.cbxDesde.Location = new System.Drawing.Point(161, 25);
            this.cbxDesde.Name = "cbxDesde";
            this.cbxDesde.Size = new System.Drawing.Size(155, 28);
            this.cbxDesde.TabIndex = 2;
            // 
            // cbxHasta
            // 
            this.cbxHasta.FormattingEnabled = true;
            this.cbxHasta.Location = new System.Drawing.Point(161, 67);
            this.cbxHasta.Name = "cbxHasta";
            this.cbxHasta.Size = new System.Drawing.Size(155, 28);
            this.cbxHasta.TabIndex = 3;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(118, 152);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(113, 42);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbHijoDadoAncestro);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbxDesde);
            this.groupBox1.Controls.Add(this.btnCalcular);
            this.groupBox1.Controls.Add(this.cbxHasta);
            this.groupBox1.Location = new System.Drawing.Point(297, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(322, 200);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Probabilidad del hijo dado el ancestro";
            // 
            // lbHijoDadoAncestro
            // 
            this.lbHijoDadoAncestro.AutoSize = true;
            this.lbHijoDadoAncestro.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbHijoDadoAncestro.Location = new System.Drawing.Point(157, 108);
            this.lbHijoDadoAncestro.Name = "lbHijoDadoAncestro";
            this.lbHijoDadoAncestro.Size = new System.Drawing.Size(109, 20);
            this.lbHijoDadoAncestro.TabIndex = 8;
            this.lbHijoDadoAncestro.Text = "                         ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Probabilidad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Evento ancestro:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Evento Hijo:";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 291);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbVer);
            this.Controls.Add(this.btnVerTodosNodos);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVerTodosNodos;
        private System.Windows.Forms.TextBox tbVer;
        private System.Windows.Forms.ComboBox cbxDesde;
        private System.Windows.Forms.ComboBox cbxHasta;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbHijoDadoAncestro;
        private System.Windows.Forms.Label label3;
    }
}

