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
    public partial class Registro_Usuario : Form
    {
        
        public Registro_Usuario()
        {
            InitializeComponent();
        }



        //metodo panel transparente
        private void paintTransparentBackground(Control c, PaintEventArgs e)
        {
            if (c.Parent == null || !Application.RenderWithVisualStyles)
                return;
            ButtonRenderer.DrawParentBackground(e.Graphics, c.ClientRectangle, c);
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            paintTransparentBackground(panel1, e);
            using (Brush b = new SolidBrush(Color.FromArgb(100, panel1.BackColor)))
            {
                e.Graphics.FillRectangle(b, e.ClipRectangle);
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            paintTransparentBackground(panel2, e);
            using (Brush b = new SolidBrush(Color.FromArgb(128, panel2.BackColor)))
            {
                e.Graphics.FillRectangle(b, e.ClipRectangle);
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            paintTransparentBackground(panel3, e);
            using (Brush b = new SolidBrush(Color.FromArgb(128, panel3.BackColor)))
            {
                e.Graphics.FillRectangle(b, e.ClipRectangle);
            }
        }

        private void Registro_Usuario_Load(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Inicio().ShowDialog();
            this.Close();
        }
        //metodo validar solo numero
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
                MessageBox.Show("Solo se admiten diguitos 0-9", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        //metodo validar solo letra
        private static void soloLetra(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }else if (char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se admiten caracteres Aa-Zz","Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumero(sender, e);
        }

        private void txtNombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloLetra(sender, e);
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumero(sender, e);
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloLetra(sender, e);
        }

        private void txtUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("No se admiten espacios", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                e.Handled = false;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(txtNombres.Text!="" && txtApellido.Text!="" && txtCedula.Text!="" && txtTelefono.Text!="" && txtDireccion.Text!="" && txtUser.Text!=""
                && txtPass.Text!="" && txtPassCon.Text != "")
            {
                if (txtPass.Text == txtPassCon.Text)
                {
                    MessageBox.Show("Muy Bien");
                }
                else
                {
                    MessageBox.Show("Contraseña no coinciden");
                }

            }
            else
            {
                MessageBox.Show("Datos incompletos");
            }
        }

        private void txtCedula_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
