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
            this.label1 = new System.Windows.Forms.Label();
            this.TBAgregar = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BTNPromedio = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.labelpromedio = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese a continuación la nota:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TBAgregar
            // 
            this.TBAgregar.Location = new System.Drawing.Point(179, 50);
            this.TBAgregar.Name = "TBAgregar";
            this.TBAgregar.Size = new System.Drawing.Size(177, 20);
            this.TBAgregar.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TBAgregar);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(362, 126);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Solicitud de ingreso de nueva nota";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(139, 89);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Agregar Nota";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelpromedio);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.BTNPromedio);
            this.groupBox2.Location = new System.Drawing.Point(12, 144);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(362, 129);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Consulta del promedio general";
            // 
            // BTNPromedio
            // 
            this.BTNPromedio.Location = new System.Drawing.Point(128, 100);
            this.BTNPromedio.Name = "BTNPromedio";
            this.BTNPromedio.Size = new System.Drawing.Size(111, 23);
            this.BTNPromedio.TabIndex = 0;
            this.BTNPromedio.Text = "Consulta Promedio";
            this.BTNPromedio.UseVisualStyleBackColor = true;
            this.BTNPromedio.Click += new System.EventHandler(this.BTNPromedio_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "El promedio resultante es:";
            // 
            // labelpromedio
            // 
            this.labelpromedio.AutoSize = true;
            this.labelpromedio.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelpromedio.Location = new System.Drawing.Point(179, 57);
            this.labelpromedio.Name = "labelpromedio";
            this.labelpromedio.Size = new System.Drawing.Size(10, 13);
            this.labelpromedio.TabIndex = 2;
            this.labelpromedio.Text = "-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 276);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Modelo de Aplicacion de Ventanas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBAgregar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BTNPromedio;
        private System.Windows.Forms.Label labelpromedio;
        private System.Windows.Forms.Label label2;
    }
}

