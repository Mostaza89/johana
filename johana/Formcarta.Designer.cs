namespace johana
{
    partial class Formcarta
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
            this.textocarta = new System.Windows.Forms.RichTextBox();
            this.bnsalir = new System.Windows.Forms.Button();
            this.bnregresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textocarta
            // 
            this.textocarta.Font = new System.Drawing.Font("Pristina", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textocarta.Location = new System.Drawing.Point(172, 97);
            this.textocarta.Name = "textocarta";
            this.textocarta.Size = new System.Drawing.Size(423, 218);
            this.textocarta.TabIndex = 0;
            this.textocarta.Text = "";
            this.textocarta.TextChanged += new System.EventHandler(this.textocarta_TextChanged);
            // 
            // bnsalir
            // 
            this.bnsalir.Location = new System.Drawing.Point(12, 415);
            this.bnsalir.Name = "bnsalir";
            this.bnsalir.Size = new System.Drawing.Size(75, 23);
            this.bnsalir.TabIndex = 1;
            this.bnsalir.Text = "Close";
            this.bnsalir.UseVisualStyleBackColor = true;
            this.bnsalir.Click += new System.EventHandler(this.bnsalir_Click);
            // 
            // bnregresar
            // 
            this.bnregresar.Location = new System.Drawing.Point(713, 415);
            this.bnregresar.Name = "bnregresar";
            this.bnregresar.Size = new System.Drawing.Size(75, 23);
            this.bnregresar.TabIndex = 2;
            this.bnregresar.Text = "Regresar";
            this.bnregresar.UseVisualStyleBackColor = true;
            this.bnregresar.Click += new System.EventHandler(this.bnregresar_Click);
            // 
            // Formcarta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bnregresar);
            this.Controls.Add(this.bnsalir);
            this.Controls.Add(this.textocarta);
            this.Name = "Formcarta";
            this.Text = "Formcarta";
            this.Load += new System.EventHandler(this.Formcarta_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox textocarta;
        private System.Windows.Forms.Button bnsalir;
        private System.Windows.Forms.Button bnregresar;
    }
}