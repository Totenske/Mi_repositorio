namespace Actividad_11624
{
    partial class Form2
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
            this.txCompetidor = new System.Windows.Forms.TextBox();
            this.btnCompetidor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // txCompetidor
            // 
            this.txCompetidor.Location = new System.Drawing.Point(130, 53);
            this.txCompetidor.Name = "txCompetidor";
            this.txCompetidor.Size = new System.Drawing.Size(247, 20);
            this.txCompetidor.TabIndex = 1;
            // 
            // btnCompetidor
            // 
            this.btnCompetidor.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnCompetidor.Location = new System.Drawing.Point(149, 100);
            this.btnCompetidor.Name = "btnCompetidor";
            this.btnCompetidor.Size = new System.Drawing.Size(115, 53);
            this.btnCompetidor.TabIndex = 2;
            this.btnCompetidor.Text = "Agregar";
            this.btnCompetidor.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 165);
            this.Controls.Add(this.btnCompetidor);
            this.Controls.Add(this.txCompetidor);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCompetidor;
        public System.Windows.Forms.TextBox txCompetidor;
    }
}