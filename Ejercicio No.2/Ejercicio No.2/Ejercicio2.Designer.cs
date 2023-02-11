
namespace Ejercicio_No._2
{
    partial class Ejercicio2
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Nota1TextBox = new System.Windows.Forms.TextBox();
            this.Nota2TextBox = new System.Windows.Forms.TextBox();
            this.Nota3TextBox = new System.Windows.Forms.TextBox();
            this.Nota4TextBox = new System.Windows.Forms.TextBox();
            this.CalculaNotaButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.PromedioTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese la nota 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingrese la nota 2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ingrese la nota 3:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ingrese la nota 4:";
            // 
            // Nota1TextBox
            // 
            this.Nota1TextBox.Location = new System.Drawing.Point(256, 91);
            this.Nota1TextBox.Name = "Nota1TextBox";
            this.Nota1TextBox.Size = new System.Drawing.Size(197, 28);
            this.Nota1TextBox.TabIndex = 4;
            // 
            // Nota2TextBox
            // 
            this.Nota2TextBox.Location = new System.Drawing.Point(256, 148);
            this.Nota2TextBox.Name = "Nota2TextBox";
            this.Nota2TextBox.Size = new System.Drawing.Size(197, 28);
            this.Nota2TextBox.TabIndex = 5;
            // 
            // Nota3TextBox
            // 
            this.Nota3TextBox.Location = new System.Drawing.Point(256, 203);
            this.Nota3TextBox.Name = "Nota3TextBox";
            this.Nota3TextBox.Size = new System.Drawing.Size(197, 28);
            this.Nota3TextBox.TabIndex = 6;
            // 
            // Nota4TextBox
            // 
            this.Nota4TextBox.Location = new System.Drawing.Point(256, 256);
            this.Nota4TextBox.Name = "Nota4TextBox";
            this.Nota4TextBox.Size = new System.Drawing.Size(197, 28);
            this.Nota4TextBox.TabIndex = 7;
            // 
            // CalculaNotaButton
            // 
            this.CalculaNotaButton.Location = new System.Drawing.Point(223, 325);
            this.CalculaNotaButton.Name = "CalculaNotaButton";
            this.CalculaNotaButton.Size = new System.Drawing.Size(148, 43);
            this.CalculaNotaButton.TabIndex = 8;
            this.CalculaNotaButton.Text = "Calcular Nota";
            this.CalculaNotaButton.UseVisualStyleBackColor = true;
            this.CalculaNotaButton.Click += new System.EventHandler(this.CalculaNotaButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 419);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "Promedio Final";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Javanese Text", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(234, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(296, 54);
            this.label6.TabIndex = 10;
            this.label6.Text = "Calcular Promedio Final";
            // 
            // PromedioTextBox
            // 
            this.PromedioTextBox.Location = new System.Drawing.Point(256, 415);
            this.PromedioTextBox.Name = "PromedioTextBox";
            this.PromedioTextBox.Size = new System.Drawing.Size(197, 28);
            this.PromedioTextBox.TabIndex = 11;
            // 
            // Ejercicio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 489);
            this.Controls.Add(this.PromedioTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CalculaNotaButton);
            this.Controls.Add(this.Nota4TextBox);
            this.Controls.Add(this.Nota3TextBox);
            this.Controls.Add(this.Nota2TextBox);
            this.Controls.Add(this.Nota1TextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Ejercicio2";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Nota1TextBox;
        private System.Windows.Forms.TextBox Nota2TextBox;
        private System.Windows.Forms.TextBox Nota3TextBox;
        private System.Windows.Forms.TextBox Nota4TextBox;
        private System.Windows.Forms.Button CalculaNotaButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox PromedioTextBox;
    }
}

