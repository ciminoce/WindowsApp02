using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsApp02
{
    public partial class FrmOperacionesBasicas : Form
    {
        public FrmOperacionesBasicas()
        {
            InitializeComponent();
        }

        private void SalirButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            LimpiarControles();
        }

        private void LimpiarControles()
        {
            Numero1TextBox.Clear();
            Numero2TextBox.Clear();
            Numero1TextBox.Focus();
        }

        private void SumarButton_Click(object sender, EventArgs e)
        {
            var numero1 = int.Parse(Numero1TextBox.Text);
            var numero2 = int.Parse(Numero2TextBox.Text);
            var suma = numero1 + numero2;
            MessageBox.Show($"El resultado de la suma es {suma}", "Resultado", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            ResultadosListBox.Items.Add(suma);
            LimpiarControles();
        }

        private void RestarButton_Click(object sender, EventArgs e)
        {
            var numero1 = int.Parse(Numero1TextBox.Text);
            var numero2 = int.Parse(Numero2TextBox.Text);
            var resta = numero1 - numero2;
            MessageBox.Show($"El resultado de la resta es {resta}", "Resultado", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            ResultadosListBox.Items.Add(resta);
            LimpiarControles();

        }

        private void MultiplicarButton_Click(object sender, EventArgs e)
        {
            var numero1 = int.Parse(Numero1TextBox.Text);
            var numero2 = int.Parse(Numero2TextBox.Text);
            var producto = numero1 * numero2;
            MessageBox.Show($"El resultado del producto es {producto}", "Resultado", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            ResultadosListBox.Items.Add(producto);
            LimpiarControles();

        }

        private void DividirButton_Click(object sender, EventArgs e)
        {
            var numero1 = int.Parse(Numero1TextBox.Text);
            var numero2 = int.Parse(Numero2TextBox.Text);
            var division = numero1 / numero2;
            MessageBox.Show($"El resultado de la división es {division}", "Resultado", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            ResultadosListBox.Items.Add(division);
            LimpiarControles();

        }
    }
}
