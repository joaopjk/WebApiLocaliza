namespace WindowsFormsDecomporNumero
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.numero = new System.Windows.Forms.TextBox();
            this.labelNumero = new System.Windows.Forms.Label();
            this.bntDecompor = new System.Windows.Forms.Button();
            this.divisores = new System.Windows.Forms.TextBox();
            this.divisoresPrimo = new System.Windows.Forms.TextBox();
            this.labelDivisores = new System.Windows.Forms.Label();
            this.labelDivisoresPrimos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // numero
            // 
            this.numero.Location = new System.Drawing.Point(84, 38);
            this.numero.Name = "numero";
            this.numero.PlaceholderText = "Digite o número a ser decomposto.";
            this.numero.Size = new System.Drawing.Size(302, 27);
            this.numero.TabIndex = 0;
            this.numero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numero_KeyPress_1);
            // 
            // labelNumero
            // 
            this.labelNumero.AutoSize = true;
            this.labelNumero.Location = new System.Drawing.Point(12, 41);
            this.labelNumero.Name = "labelNumero";
            this.labelNumero.Size = new System.Drawing.Size(66, 20);
            this.labelNumero.TabIndex = 1;
            this.labelNumero.Text = "Número:";
            // 
            // bntDecompor
            // 
            this.bntDecompor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bntDecompor.Location = new System.Drawing.Point(420, 37);
            this.bntDecompor.Name = "bntDecompor";
            this.bntDecompor.Size = new System.Drawing.Size(94, 29);
            this.bntDecompor.TabIndex = 2;
            this.bntDecompor.Text = "Decompor ";
            this.bntDecompor.UseVisualStyleBackColor = true;
            this.bntDecompor.Click += new System.EventHandler(this.bntDecompor_Click);
            // 
            // divisores
            // 
            this.divisores.Location = new System.Drawing.Point(84, 169);
            this.divisores.Multiline = true;
            this.divisores.Name = "divisores";
            this.divisores.ReadOnly = true;
            this.divisores.Size = new System.Drawing.Size(535, 72);
            this.divisores.TabIndex = 3;
            // 
            // divisoresPrimo
            // 
            this.divisoresPrimo.Location = new System.Drawing.Point(84, 315);
            this.divisoresPrimo.Multiline = true;
            this.divisoresPrimo.Name = "divisoresPrimo";
            this.divisoresPrimo.ReadOnly = true;
            this.divisoresPrimo.Size = new System.Drawing.Size(535, 72);
            this.divisoresPrimo.TabIndex = 3;
            // 
            // labelDivisores
            // 
            this.labelDivisores.AutoSize = true;
            this.labelDivisores.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelDivisores.Location = new System.Drawing.Point(84, 133);
            this.labelDivisores.Name = "labelDivisores";
            this.labelDivisores.Size = new System.Drawing.Size(73, 20);
            this.labelDivisores.TabIndex = 4;
            this.labelDivisores.Text = "Divisores";
            // 
            // labelDivisoresPrimos
            // 
            this.labelDivisoresPrimos.AutoSize = true;
            this.labelDivisoresPrimos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelDivisoresPrimos.Location = new System.Drawing.Point(84, 281);
            this.labelDivisoresPrimos.Name = "labelDivisoresPrimos";
            this.labelDivisoresPrimos.Size = new System.Drawing.Size(126, 20);
            this.labelDivisoresPrimos.TabIndex = 4;
            this.labelDivisoresPrimos.Text = "Divisores Primos";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelDivisoresPrimos);
            this.Controls.Add(this.labelDivisores);
            this.Controls.Add(this.divisoresPrimo);
            this.Controls.Add(this.divisores);
            this.Controls.Add(this.bntDecompor);
            this.Controls.Add(this.labelNumero);
            this.Controls.Add(this.numero);
            this.Name = "Form1";
            this.Text = "Decompor Número";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox numero;
        private System.Windows.Forms.Label labelNumero;
        private System.Windows.Forms.Button bntDecompor;
        private System.Windows.Forms.TextBox divisores;
        private System.Windows.Forms.TextBox divisoresPrimo;
        private System.Windows.Forms.Label labelDivisores;
        private System.Windows.Forms.Label labelDivisoresPrimos;
    }
}

