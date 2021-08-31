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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {
            txtPass.UseSystemPasswordChar = true;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            paintTransparentBackground(panel2, e);
            using(Brush b = new SolidBrush(Color.FromArgb(128, panel2.BackColor)))
            {
                e.Graphics.FillRectangle(b, e.ClipRectangle);
            }
        }

        private void paintTransparentBackground(Control c , PaintEventArgs e)
        {
            if (c.Parent == null || !Application.RenderWithVisualStyles)
                return;
            ButtonRenderer.DrawParentBackground(e.Graphics, c.ClientRectangle, c);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            paintTransparentBackground(panel3, e);
            using (Brush b = new SolidBrush(Color.FromArgb(128, panel3.BackColor)))
            {
                e.Graphics.FillRectangle(b, e.ClipRectangle);
            }
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            paintTransparentBackground(panel5, e);
            using (Brush b = new SolidBrush(Color.FromArgb(128, panel5.BackColor)))
            {
                e.Graphics.FillRectangle(b, e.ClipRectangle);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "" && txtPass.Text == "")
            {
                MessageBox.Show("Favor llenar los campos");
                txtUser.Text = "";
                txtPass.Text = "";
                txtUser.Focus();
                 
            }
            else
            {
                if (txtPass.Text == "")
                {
                    MessageBox.Show("Favor llenar los campos");
                    
                    txtPass.Text = "";
                    txtPass.Focus();

                }
                else
                {
                    if (txtUser.Text == "")
                    {
                        MessageBox.Show("Favor llenar los campos");

                        txtUser.Text = "";
                        txtUser.Focus();

                    }
                    else
                    {
                        this.Hide();
                new Inicio().ShowDialog();
                    }
                }
            }

        }

        private void cbxVer_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxVer.Checked)
            {
                txtPass.UseSystemPasswordChar = false;
            }
            else
            {
                txtPass.UseSystemPasswordChar = true;
            }
        }
    }
}
