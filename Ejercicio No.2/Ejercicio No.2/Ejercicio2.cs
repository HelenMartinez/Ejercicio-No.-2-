using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_No._2
{
    public partial class Ejercicio2 : Form
    {
        public Ejercicio2()
        {
            InitializeComponent();
        }

        private async void CalculaNotaButton_Click(object sender, EventArgs e)
        {
            decimal not1 = Convert.ToDecimal(Nota1TextBox.Text);
            decimal not2 = Convert.ToDecimal(Nota2TextBox.Text);
            decimal not3 = Convert.ToDecimal(Nota3TextBox.Text);
            decimal not4 = Convert.ToDecimal(Nota4TextBox.Text);

            decimal promedio = await ResultadoAsync(not1, not2, not3, not4);
            PromedioTextBox.Text = Convert.ToString(promedio);
        }

        private async Task<decimal> ResultadoAsync(decimal n1, decimal n2, decimal n3, decimal n4) 
        {
            decimal notafinal = await Task.Run(() =>
            {
                return (n1 + n2 + n3 + n4) / 4;
            });
            return notafinal;
        }     
    }
}
