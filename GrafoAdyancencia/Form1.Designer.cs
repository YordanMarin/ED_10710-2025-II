namespace GrafoAdyancencia
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
            this.btnMatriz = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnAmplitud = new System.Windows.Forms.Button();
            this.btnProfundidad = new System.Windows.Forms.Button();
            this.textAmplitud = new System.Windows.Forms.TextBox();
            this.textProfundidad = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(181, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 31);
            this.label1.TabIndex = 30;
            this.label1.Text = "GRAFOS DIRIGIDOS";
            // 
            // btnMatriz
            // 
            this.btnMatriz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMatriz.Location = new System.Drawing.Point(187, 67);
            this.btnMatriz.Margin = new System.Windows.Forms.Padding(2);
            this.btnMatriz.Name = "btnMatriz";
            this.btnMatriz.Size = new System.Drawing.Size(448, 44);
            this.btnMatriz.TabIndex = 37;
            this.btnMatriz.Text = "MATRIZ DE ADYACENCIA";
            this.btnMatriz.UseVisualStyleBackColor = true;
            this.btnMatriz.Click += new System.EventHandler(this.btnMatriz_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(187, 127);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(448, 197);
            this.richTextBox1.TabIndex = 38;
            this.richTextBox1.Text = "";
            // 
            // btnAmplitud
            // 
            this.btnAmplitud.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAmplitud.Location = new System.Drawing.Point(187, 343);
            this.btnAmplitud.Margin = new System.Windows.Forms.Padding(2);
            this.btnAmplitud.Name = "btnAmplitud";
            this.btnAmplitud.Size = new System.Drawing.Size(110, 38);
            this.btnAmplitud.TabIndex = 39;
            this.btnAmplitud.Text = "Amplitud";
            this.btnAmplitud.UseVisualStyleBackColor = true;
            this.btnAmplitud.Click += new System.EventHandler(this.btnAmplitud_Click);
            // 
            // btnProfundidad
            // 
            this.btnProfundidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfundidad.Location = new System.Drawing.Point(187, 386);
            this.btnProfundidad.Margin = new System.Windows.Forms.Padding(2);
            this.btnProfundidad.Name = "btnProfundidad";
            this.btnProfundidad.Size = new System.Drawing.Size(110, 38);
            this.btnProfundidad.TabIndex = 40;
            this.btnProfundidad.Text = "Profundidad";
            this.btnProfundidad.UseVisualStyleBackColor = true;
            this.btnProfundidad.Click += new System.EventHandler(this.btnProfundidad_Click);
            // 
            // textAmplitud
            // 
            this.textAmplitud.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textAmplitud.Location = new System.Drawing.Point(301, 349);
            this.textAmplitud.Margin = new System.Windows.Forms.Padding(2);
            this.textAmplitud.Name = "textAmplitud";
            this.textAmplitud.Size = new System.Drawing.Size(334, 26);
            this.textAmplitud.TabIndex = 41;
            // 
            // textProfundidad
            // 
            this.textProfundidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textProfundidad.Location = new System.Drawing.Point(301, 392);
            this.textProfundidad.Margin = new System.Windows.Forms.Padding(2);
            this.textProfundidad.Name = "textProfundidad";
            this.textProfundidad.Size = new System.Drawing.Size(334, 26);
            this.textProfundidad.TabIndex = 42;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 460);
            this.Controls.Add(this.textProfundidad);
            this.Controls.Add(this.textAmplitud);
            this.Controls.Add(this.btnProfundidad);
            this.Controls.Add(this.btnAmplitud);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnMatriz);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMatriz;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnAmplitud;
        private System.Windows.Forms.Button btnProfundidad;
        private System.Windows.Forms.TextBox textAmplitud;
        private System.Windows.Forms.TextBox textProfundidad;
    }
}

