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

        private int numero1 = 0;
        private int numero2 = 0;

        //private int operacion = 0;//Para ver que operacion básica voy a realizar
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
            if (ValidarDatos())
            {
                //var numero1 = int.Parse(Numero1TextBox.Text);
                //var numero2 = int.Parse(Numero2TextBox.Text);

                //var suma = numero1 + numero2;
                //MessageBox.Show($"El resultado de la suma es {suma}", "Resultado", MessageBoxButtons.OK,
                //    MessageBoxIcon.Information);
                //ResultadosListBox.Items.Add(suma);
                //LimpiarControles();

                //operacion = 0;
                //EjecutarOperacion(operacion);
                EjecutarOperacion(OperacionBasica.Suma);

            }

        }

        private void EjecutarOperacion(OperacionBasica operacion)
        {
            int resultado = 0;
            //string operacionRealizada = "";
            switch (operacion)
            {
                case OperacionBasica.Suma:
                    resultado = numero1 + numero2;
                    //operacionRealizada = "suma";
                    break;
                case OperacionBasica.Resta:
                    resultado = numero1 - numero2;
                    //operacionRealizada = "resta";

                    break;
                case OperacionBasica.Multiplicación:
                    resultado = numero1 * numero2;
                    //operacionRealizada = "multiplicación";
                    break;
                case OperacionBasica.División:
                    if (numero2!=0)
                    {
                        resultado = numero1 / numero2;
                        //operacionRealizada = "división";

                    }
                    else
                    {
                        MessageBox.Show("No se puede dividir por 0", "Advertencia", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        Numero2TextBox.SelectAll();
                        Numero2TextBox.Focus();
                        return;
                    }
                    break;
                default:
                    break;
            }
            MessageBox.Show($"El resultado de la {operacion.ToString()} es {resultado}", "Resultado", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
            ResultadosListBox.Items.Add(resultado);
            LimpiarControles();

        }

        private bool ValidarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            if (!int.TryParse(Numero1TextBox.Text, out numero1))
            {
                valido = false;
                errorProvider1.SetError(Numero1TextBox,"Número mal ingresado");
            }
            if (!int.TryParse(Numero2TextBox.Text, out numero2))
            {
                valido = false;
                errorProvider1.SetError(Numero2TextBox, "Número mal ingresado");
            }

            return valido;
        }

        private void RestarButton_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                //var numero1 = int.Parse(Numero1TextBox.Text);
                //var numero2 = int.Parse(Numero2TextBox.Text);
                //var resta = numero1 - numero2;
                //MessageBox.Show($"El resultado de la resta es {resta}", "Resultado", MessageBoxButtons.OK,
                //    MessageBoxIcon.Information);
                //ResultadosListBox.Items.Add(resta);
                //LimpiarControles();
                //operacion = 1;
                //EjecutarOperacion(operacion);
                EjecutarOperacion(OperacionBasica.Resta);
            }
        }

        private void MultiplicarButton_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                //var numero1 = int.Parse(Numero1TextBox.Text);
                //var numero2 = int.Parse(Numero2TextBox.Text);
                //var producto = numero1 * numero2;
                //MessageBox.Show($"El resultado del producto es {producto}", "Resultado", MessageBoxButtons.OK,
                //    MessageBoxIcon.Information);
                //ResultadosListBox.Items.Add(producto);
                //LimpiarControles();
                //operacion = 2;
                //EjecutarOperacion(operacion);
                EjecutarOperacion(OperacionBasica.Multiplicación);

            }
        }

        private void DividirButton_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                //var numero1 = int.Parse(Numero1TextBox.Text);
                //var numero2 = int.Parse(Numero2TextBox.Text);
                //if (numero2!=0)
                //{
                //    var division = numero1 / numero2;
                //    MessageBox.Show($"El resultado de la división es {division}", "Resultado", MessageBoxButtons.OK,
                //        MessageBoxIcon.Information);
                //    ResultadosListBox.Items.Add(division);
                //    LimpiarControles();

                //}
                //else
                //{
                //    MessageBox.Show("No se puede dividir por 0", "Advertencia", MessageBoxButtons.OK,
                //        MessageBoxIcon.Warning);
                //    Numero2TextBox.SelectAll();
                //    Numero2TextBox.Focus();
                //}
                //operacion = 3;
                //EjecutarOperacion(operacion);
                EjecutarOperacion(OperacionBasica.División);

            }
        }
    }
}
