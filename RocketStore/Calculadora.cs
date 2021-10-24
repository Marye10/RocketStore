using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RocketStore
{
    public partial class Calculadora : Form
    {
        double Numero1 = 0, Numero2 = 0;
        char Operador;

        public Calculadora()
        {
            InitializeComponent();
        }

        private void agregarNumero(string numero)
        {
            if (BtoResultado.Text == "0")
                BtoResultado.Text = "";
            BtoResultado.Text += numero;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            var boton = ((Button)sender);
            agregarNumero(boton.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var boton = ((Button)sender);
            agregarNumero(boton.Text);
        }

        private void BtoResultado_Click(object sender, EventArgs e)
        {

        }

        private void BtoCero_Click(object sender, EventArgs e)
        {
            var boton = ((Button)sender);
            agregarNumero(boton.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtoDividir_Click(object sender, EventArgs e)
        {

        }

        private void BtoDos_Click(object sender, EventArgs e)
        {
            var boton = ((Button)sender);
            agregarNumero(boton.Text);
        }

        private void BtoCuatro_Click(object sender, EventArgs e)
        {
            var boton = ((Button)sender);
            agregarNumero(boton.Text);
        }

        private void BtoCinco_Click(object sender, EventArgs e)
        {
            var boton = ((Button)sender);
            agregarNumero(boton.Text);
        }

        private void BtoSeis_Click(object sender, EventArgs e)
        {
            var boton = ((Button)sender);
            agregarNumero(boton.Text);
        }

        private void BtoSiete_Click(object sender, EventArgs e)
        {
            var boton = ((Button)sender);
            agregarNumero(boton.Text);
        }

        private void BtoOcho_Click(object sender, EventArgs e)
        {
            var boton = ((Button)sender);
            agregarNumero(boton.Text);
        }

        private void BtoNueve_Click(object sender, EventArgs e)
        {
            var boton = ((Button)sender);
            agregarNumero(boton.Text);
        }
        private void clickOperador(Object sender, EventArgs e)
        {
            Numero1 = Convert.ToDouble(BtoResultado.Text);
            var boton = ((Button)sender);
            agregarNumero(boton.Text);
            Operador = Convert.ToChar(boton.Text);
        }

        private void BtoSuma_Click(object sender, EventArgs e)
        {
            Numero1 = Convert.ToDouble(BtoResultado.Text);
            Operador = '+';
        }
    }
}
