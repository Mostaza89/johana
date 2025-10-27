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
            this.SuspendLayout();
            // 
            // textocarta
            // 
            this.textocarta.Location = new System.Drawing.Point(250, 133);
            this.textocarta.Name = "textocarta";
            this.textocarta.Size = new System.Drawing.Size(100, 96);
            this.textocarta.TabIndex = 0;
            this.textocarta.Text = "";
            this.textocarta.TextChanged += new System.EventHandler(this.textocarta_TextChanged);
            // 
            // Formcarta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textocarta);
            this.Name = "Formcarta";
            this.Text = "Formcarta";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox textocarta;
    }
}