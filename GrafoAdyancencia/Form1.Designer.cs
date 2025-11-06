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
            this.label2 = new System.Windows.Forms.Label();
            this.textOrigen = new System.Windows.Forms.TextBox();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textDestino = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 31;
            this.label2.Text = "Origen:";
            // 
            // textOrigen
            // 
            this.textOrigen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textOrigen.Location = new System.Drawing.Point(100, 67);
            this.textOrigen.Margin = new System.Windows.Forms.Padding(2);
            this.textOrigen.Name = "textOrigen";
            this.textOrigen.Size = new System.Drawing.Size(62, 26);
            this.textOrigen.TabIndex = 32;
            // 
            // btnInsertar
            // 
            this.btnInsertar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertar.Location = new System.Drawing.Point(65, 139);
            this.btnInsertar.Margin = new System.Windows.Forms.Padding(2);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(97, 38);
            this.btnInsertar.TabIndex = 33;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 103);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 34;
            this.label3.Text = "Destino:";
            // 
            // textDestino
            // 
            this.textDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDestino.Location = new System.Drawing.Point(100, 97);
            this.textDestino.Margin = new System.Windows.Forms.Padding(2);
            this.textDestino.Name = "textDestino";
            this.textDestino.Size = new System.Drawing.Size(62, 26);
            this.textDestino.TabIndex = 35;
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(36, 200);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(126, 224);
            this.listBox1.TabIndex = 36;
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
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textDestino);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.textOrigen);
            this.Controls.Add(this.label2);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textOrigen;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textDestino;
        private System.Windows.Forms.ListBox listBox1;
    }
}

