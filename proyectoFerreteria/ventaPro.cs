using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectoFerreteria
{
    public partial class ventaPro : Form
    {
        public ventaPro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Registra_Clientes().ShowDialog();
        }
        private static void soloLetra(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }else if (char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se admiten caracteres Aa-Zz", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private static void soloNumero(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se admiten digitos 0-9", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txtComprobante_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumero(sender, e);
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumero(sender, e);
        }

        private void txtCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloLetra(sender, e);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtCantidad.Text != "" && txtComprobante.Text!="" && txtCliente.Text != "")
            {
                MessageBox.Show("Bien");
                txtComprobante.Text = "";
                txtCantidad.Text = "";
                txtCliente.Text = "";
                dateTimePicker1.Value = DateTime.Now;
                txtComprobante.Focus();
            }
            else
            {
                MessageBox.Show("Complete los campos vacios");
            }
        }
    }
}
