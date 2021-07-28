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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            ocultar();
        }
        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //ocultar paneles de submenu
        private void ocultar()
        {
            pnlSubHerr.Visible = false;
            pnlSubMante.Visible = false;
        }
        //ocultar submenu
        private void ocultarSubmenu()
        {
            if (pnlSubHerr.Visible == true)
                pnlSubHerr.Visible = false;
            if (pnlSubMante.Visible == true)
                pnlSubMante.Visible = false;
        }
        //mostrar submenu
        private void mostrarSubmenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                ocultarSubmenu();
                submenu.Visible = true;
            }
            else
            {
                submenu.Visible = false;
            }
        }

        private void btnHerramientas_Click(object sender, EventArgs e)
        {
            mostrarSubmenu(pnlSubHerr);
        }

        private void btnMantenimiento_Click(object sender, EventArgs e)
        {
            mostrarSubmenu(pnlSubMante);
        }
        private void paintTransparentBackground(Control c, PaintEventArgs e)
        {
            if (c.Parent == null || !Application.RenderWithVisualStyles)
                return;
            ButtonRenderer.DrawParentBackground(e.Graphics, c.ClientRectangle, c);
        }
        private void pnlContenedor_Paint(object sender, PaintEventArgs e)
        {
            paintTransparentBackground(pnlContenedor, e);
            using (Brush b = new SolidBrush(Color.FromArgb(100, pnlContenedor.BackColor)))
            {
                e.Graphics.FillRectangle(b, e.ClipRectangle);
            }
        }

        private Form activarForm = null;
        private void abrirFormulario(Form childForm)
        {
            if (activarForm != null)
                activarForm.Close();
            activarForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlContenedor.Controls.Add(childForm);
            pnlContenedor.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnAgregarPro_Click(object sender, EventArgs e)
        {
            abrirFormulario(new Registro_Proveedor());
        }

        private void btnAgregarRol_Click(object sender, EventArgs e)
        {
            abrirFormulario(new Registro_Rol());
        }
    }
}
