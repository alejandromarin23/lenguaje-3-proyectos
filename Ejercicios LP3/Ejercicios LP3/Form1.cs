using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicios_LP3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       private async void button1_ClickAsync(object sender, EventArgs e)
        {
            decimal parcial1 = Convert.ToDecimal(textBox1.Text);
            decimal parcial2 = Convert.ToDecimal(textBox2.Text);
            decimal parcial3 = Convert.ToDecimal(textBox3.Text);
            decimal parcial4 = Convert.ToDecimal(textBox4.Text);

            decimal promediofinal = await PromedioAsync(parcial1, parcial2, parcial3, parcial4);
            MessageBox.Show($"el promedio final es :{promediofinal}");
            limpiarcontroles();
            textBox1.Focus();
        }

        private void limpiarcontroles()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }
        private async Task<decimal> PromedioAsync(decimal n1, decimal n2, decimal n3, decimal n4)
        {
            decimal promedio = await Task.Run(() =>
                           {
                               return (n1 + n2 + n3 + n4) / 4;
                           });
          
            return promedio;
        }
    }
    
}
