namespace Actividad_4624
{
    partial class Form1
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
            this.tbIngreso = new System.Windows.Forms.TextBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelpromedio = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.binarioSecuencia = new System.Windows.Forms.RadioButton();
            this.radioSecuencia = new System.Windows.Forms.RadioButton();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnbusqueda = new System.Windows.Forms.Button();
            this.btncalcular = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lbResultado = new System.Windows.Forms.ListBox();
            this.btnListar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnIngresar);
            this.groupBox1.Controls.Add(this.tbIngreso);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(415, 114);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingresar número";
            // 
            // tbIngreso
            // 
            this.tbIngreso.Location = new System.Drawing.Point(19, 51);
            this.tbIngreso.Name = "tbIngreso";
            this.tbIngreso.Size = new System.Drawing.Size(198, 20);
            this.tbIngreso.TabIndex = 0;
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(279, 49);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(96, 23);
            this.btnIngresar.TabIndex = 1;
            this.btnIngresar.Text = "Agregar número";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btncalcular);
            this.groupBox2.Controls.Add(this.labelpromedio);
            this.groupBox2.Location = new System.Drawing.Point(12, 132);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(415, 89);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mostrar promedio";
            // 
            // labelpromedio
            // 
            this.labelpromedio.AutoSize = true;
            this.labelpromedio.Location = new System.Drawing.Point(16, 48);
            this.labelpromedio.Name = "labelpromedio";
            this.labelpromedio.Size = new System.Drawing.Size(35, 13);
            this.labelpromedio.TabIndex = 0;
            this.labelpromedio.Text = "label1";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnbusqueda);
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Controls.Add(this.radioSecuencia);
            this.groupBox3.Controls.Add(this.binarioSecuencia);
            this.groupBox3.Location = new System.Drawing.Point(12, 227);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(415, 150);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Busqueda de número";
            // 
            // binarioSecuencia
            // 
            this.binarioSecuencia.AutoSize = true;
            this.binarioSecuencia.Location = new System.Drawing.Point(19, 103);
            this.binarioSecuencia.Name = "binarioSecuencia";
            this.binarioSecuencia.Size = new System.Drawing.Size(57, 17);
            this.binarioSecuencia.TabIndex = 0;
            this.binarioSecuencia.TabStop = true;
            this.binarioSecuencia.Text = "Binario";
            this.binarioSecuencia.UseVisualStyleBackColor = true;
            // 
            // radioSecuencia
            // 
            this.radioSecuencia.AutoSize = true;
            this.radioSecuencia.Location = new System.Drawing.Point(19, 80);
            this.radioSecuencia.Name = "radioSecuencia";
            this.radioSecuencia.Size = new System.Drawing.Size(78, 17);
            this.radioSecuencia.TabIndex = 1;
            this.radioSecuencia.TabStop = true;
            this.radioSecuencia.Text = "Secuencial";
            this.radioSecuencia.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(19, 42);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(198, 20);
            this.textBox2.TabIndex = 2;
            // 
            // btnbusqueda
            // 
            this.btnbusqueda.Location = new System.Drawing.Point(279, 39);
            this.btnbusqueda.Name = "btnbusqueda";
            this.btnbusqueda.Size = new System.Drawing.Size(96, 23);
            this.btnbusqueda.TabIndex = 3;
            this.btnbusqueda.Text = "Búsqueda";
            this.btnbusqueda.UseVisualStyleBackColor = true;
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(279, 37);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(96, 23);
            this.btncalcular.TabIndex = 1;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnListar);
            this.groupBox4.Controls.Add(this.lbResultado);
            this.groupBox4.Location = new System.Drawing.Point(446, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(241, 365);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Lista Ordenada";
            // 
            // lbResultado
            // 
            this.lbResultado.FormattingEnabled = true;
            this.lbResultado.Location = new System.Drawing.Point(17, 19);
            this.lbResultado.Name = "lbResultado";
            this.lbResultado.Size = new System.Drawing.Size(120, 329);
            this.lbResultado.TabIndex = 0;
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(143, 19);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(92, 37);
            this.btnListar.TabIndex = 1;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 389);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbIngreso;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Label labelpromedio;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnbusqueda;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.RadioButton radioSecuencia;
        private System.Windows.Forms.RadioButton binarioSecuencia;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.ListBox lbResultado;
    }
}

