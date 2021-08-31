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
    public partial class Registro_Proveedor : Form
    {
        public Registro_Proveedor()
        {
            InitializeComponent();
        }



        private void paintTransparentBackground(Control c, PaintEventArgs e)
        {
            if (c.Parent == null || !Application.RenderWithVisualStyles)
                return;
            ButtonRenderer.DrawParentBackground(e.Graphics, c.ClientRectangle, c);
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {
            paintTransparentBackground(panel1, e);
            using (Brush b = new SolidBrush(Color.FromArgb(100, panel1.BackColor)))
            {
                e.Graphics.FillRectangle(b, e.ClipRectangle);
            }


        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtNombres_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCedula_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Registro_Proveedor_Load(object sender, EventArgs e)
        {
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            new login().ShowDialog();
            this.Close();
        }
        //metodo solo letras
        private static void soloLetra(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo de admiten caracteres Aa-Zz", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //metodo solo numeros
        private static void soloNumero(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se admiten digitos 0-9", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumero(sender, e);
        }

        private void txtEncargado_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloLetra(sender, e);
        }

        private void txtProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloLetra(sender, e);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(txtCedula.Text!="" && txtEncargado.Text!="" && txtProveedor.Text!="" && txtDireccion.Text != "")
            {
                btnGuardar.Enabled = false;
                MessageBox.Show("Muy bein");
            }
            else
            {
                MessageBox.Show("Falta completar campos");

            }
        }
    }

}
