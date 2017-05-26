namespace ProyectoProgra3
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
            this.guardartodosdatos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // guardartodosdatos
            // 
            this.guardartodosdatos.Location = new System.Drawing.Point(13, 459);
            this.guardartodosdatos.Name = "guardartodosdatos";
            this.guardartodosdatos.Size = new System.Drawing.Size(167, 42);
            this.guardartodosdatos.TabIndex = 0;
            this.guardartodosdatos.Text = "Guardar todos los Datos";
            this.guardartodosdatos.UseVisualStyleBackColor = true;
            this.guardartodosdatos.Click += new System.EventHandler(this.guardartodosdatos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 621);
            this.Controls.Add(this.guardartodosdatos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button guardartodosdatos;
    }
}

