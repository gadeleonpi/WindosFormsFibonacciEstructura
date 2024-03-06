using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L4GADLP3036805
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void concatenarCad(ref string cadena, string addicionar)
        {
            cadena = cadena + ", " + addicionar;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int n = 0;
          
            string resultado = "";
            n = int.Parse(textBox1.Text.ToString());
           /*Agregue el código basandose en la serie de Fibonacci*/
            label3.Text = resultado;
        }
    }
}
