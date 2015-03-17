using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Racionales.Model;

namespace Racionales
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n1 = Convert.ToInt16(textBox1.Text);
            int d1 = Convert.ToInt16(textBox2.Text);
            int n2 = Convert.ToInt16(textBox6.Text);
            int d2 = Convert.ToInt16(textBox5.Text);

            Racional r1 = new Racional(n1, d1);
            Racional r2 = new Racional(n2, d2);

            Racional producto = r1.multiplicar(r2);
            

            textBox9.Text = producto.getNumerador().ToString();
            textBox8.Text = producto.getDenominador().ToString(); 
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            int n1 = Convert.ToInt16(textBox1.Text);
            int d1 = Convert.ToInt16(textBox2.Text);
            int n2 = Convert.ToInt16(textBox6.Text);
            int d2 = Convert.ToInt16(textBox5.Text);

            Racional r1 = new Racional(n1, d1);
            Racional r2 = new Racional(n2, d2);

            Racional dividir = r1.dividir(r2);


            textBox8.Text = dividir.getDenominador().ToString();
            textBox9.Text = dividir.getNumerador().ToString();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            int n1 = Convert.ToInt16(textBox1.Text);
            int d1 = Convert.ToInt16(textBox2.Text);
            int n2 = Convert.ToInt16(textBox6.Text);
            int d2 = Convert.ToInt16(textBox5.Text);

            Racional r1 = new Racional(n1, d1);
            Racional r2 = new Racional(n2, d2);

            Racional sumar = r1.sumar(r2);


            textBox9.Text = sumar.getNumerador().ToString();
            textBox8.Text = sumar.getDenominador().ToString();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            int n1 = Convert.ToInt16(textBox1.Text);
            int d1 = Convert.ToInt16(textBox2.Text);
            int n2 = Convert.ToInt16(textBox6.Text);
            int d2 = Convert.ToInt16(textBox5.Text);

            Racional r1 = new Racional(n1, d1);
            Racional r2 = new Racional(n2, d2);

            Racional restar = r1.restar(r2);


            textBox9.Text = restar.getNumerador().ToString();
            textBox8.Text = restar.getDenominador().ToString();
        }
        

       
        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

       

        private void textBox2_TextChanged(object sender, EventArgs e)
        {


        }

       

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {
           
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        

       
    }
}
