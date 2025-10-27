namespace johana
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
            this.lbtitulo = new System.Windows.Forms.Label();
            this.bncarta = new System.Windows.Forms.Button();
            this.bnsalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbtitulo
            // 
            this.lbtitulo.AutoSize = true;
            this.lbtitulo.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtitulo.Location = new System.Drawing.Point(326, 20);
            this.lbtitulo.Name = "lbtitulo";
            this.lbtitulo.Size = new System.Drawing.Size(143, 25);
            this.lbtitulo.TabIndex = 0;
            this.lbtitulo.Text = "Mi carta para ti";
            // 
            // bncarta
            // 
            this.bncarta.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bncarta.Location = new System.Drawing.Point(341, 187);
            this.bncarta.Name = "bncarta";
            this.bncarta.Size = new System.Drawing.Size(116, 39);
            this.bncarta.TabIndex = 1;
            this.bncarta.Text = "Abrir carta";
            this.bncarta.UseVisualStyleBackColor = true;
            this.bncarta.Click += new System.EventHandler(this.bncarta_Click);
            // 
            // bnsalir
            // 
            this.bnsalir.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnsalir.Location = new System.Drawing.Point(12, 410);
            this.bnsalir.Name = "bnsalir";
            this.bnsalir.Size = new System.Drawing.Size(87, 28);
            this.bnsalir.TabIndex = 2;
            this.bnsalir.Text = "Salir";
            this.bnsalir.UseVisualStyleBackColor = true;
            this.bnsalir.Click += new System.EventHandler(this.bnsalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bnsalir);
            this.Controls.Add(this.bncarta);
            this.Controls.Add(this.lbtitulo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbtitulo;
        private System.Windows.Forms.Button bncarta;
        private System.Windows.Forms.Button bnsalir;
    }
}

