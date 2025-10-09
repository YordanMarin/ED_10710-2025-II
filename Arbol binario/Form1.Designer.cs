namespace Arbol_binario
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
            this.btnInsertarRaiz = new System.Windows.Forms.Button();
            this.textNumero = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnInsertarRama = new System.Windows.Forms.Button();
            this.btnAltura = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.radioIzquierda = new System.Windows.Forms.RadioButton();
            this.radioDerecha = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnInsertarRaiz
            // 
            this.btnInsertarRaiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertarRaiz.Location = new System.Drawing.Point(35, 144);
            this.btnInsertarRaiz.Margin = new System.Windows.Forms.Padding(2);
            this.btnInsertarRaiz.Name = "btnInsertarRaiz";
            this.btnInsertarRaiz.Size = new System.Drawing.Size(146, 38);
            this.btnInsertarRaiz.TabIndex = 7;
            this.btnInsertarRaiz.Text = "Insertar raíz";
            this.btnInsertarRaiz.UseVisualStyleBackColor = true;
            this.btnInsertarRaiz.Click += new System.EventHandler(this.btnInsertarRaiz_Click);
            // 
            // textNumero
            // 
            this.textNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNumero.Location = new System.Drawing.Point(178, 82);
            this.textNumero.Margin = new System.Windows.Forms.Padding(2);
            this.textNumero.Name = "textNumero";
            this.textNumero.Size = new System.Drawing.Size(242, 26);
            this.textNumero.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 88);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ingrese número:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(140, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "ÁRBOL BINARIO";
            // 
            // btnInsertarRama
            // 
            this.btnInsertarRama.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertarRama.Location = new System.Drawing.Point(35, 199);
            this.btnInsertarRama.Margin = new System.Windows.Forms.Padding(2);
            this.btnInsertarRama.Name = "btnInsertarRama";
            this.btnInsertarRama.Size = new System.Drawing.Size(146, 38);
            this.btnInsertarRama.TabIndex = 8;
            this.btnInsertarRama.Text = "Insertar rama";
            this.btnInsertarRama.UseVisualStyleBackColor = true;
            this.btnInsertarRama.Click += new System.EventHandler(this.btnInsertarRama_Click);
            // 
            // btnAltura
            // 
            this.btnAltura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAltura.Location = new System.Drawing.Point(35, 386);
            this.btnAltura.Margin = new System.Windows.Forms.Padding(2);
            this.btnAltura.Name = "btnAltura";
            this.btnAltura.Size = new System.Drawing.Size(146, 38);
            this.btnAltura.TabIndex = 9;
            this.btnAltura.Text = "Altura";
            this.btnAltura.UseVisualStyleBackColor = true;
            this.btnAltura.Click += new System.EventHandler(this.btnAltura_Click);
            // 
            // treeView1
            // 
            this.treeView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView1.Location = new System.Drawing.Point(207, 144);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(213, 280);
            this.treeView1.TabIndex = 10;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // radioIzquierda
            // 
            this.radioIzquierda.AutoSize = true;
            this.radioIzquierda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioIzquierda.Location = new System.Drawing.Point(72, 260);
            this.radioIzquierda.Name = "radioIzquierda";
            this.radioIzquierda.Size = new System.Drawing.Size(93, 24);
            this.radioIzquierda.TabIndex = 11;
            this.radioIzquierda.TabStop = true;
            this.radioIzquierda.Text = "Izquierda";
            this.radioIzquierda.UseVisualStyleBackColor = true;
            // 
            // radioDerecha
            // 
            this.radioDerecha.AutoSize = true;
            this.radioDerecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioDerecha.Location = new System.Drawing.Point(72, 299);
            this.radioDerecha.Name = "radioDerecha";
            this.radioDerecha.Size = new System.Drawing.Size(88, 24);
            this.radioDerecha.TabIndex = 12;
            this.radioDerecha.TabStop = true;
            this.radioDerecha.Text = "Derecha";
            this.radioDerecha.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 486);
            this.Controls.Add(this.radioDerecha);
            this.Controls.Add(this.radioIzquierda);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.btnAltura);
            this.Controls.Add(this.btnInsertarRama);
            this.Controls.Add(this.btnInsertarRaiz);
            this.Controls.Add(this.textNumero);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInsertarRaiz;
        private System.Windows.Forms.TextBox textNumero;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInsertarRama;
        private System.Windows.Forms.Button btnAltura;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.RadioButton radioIzquierda;
        private System.Windows.Forms.RadioButton radioDerecha;
    }
}

