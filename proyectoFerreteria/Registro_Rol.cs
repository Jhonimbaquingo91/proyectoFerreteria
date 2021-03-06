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
    public partial class Registro_Rol : Form
    {
        public Registro_Rol()
        {
            InitializeComponent();
        }


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

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            paintTransparentBackground(panel3, e);
            using (Brush b = new SolidBrush(Color.FromArgb(100, panel3.BackColor)))
            {
                e.Graphics.FillRectangle(b, e.ClipRectangle);
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            new login().ShowDialog();
            this.Close();
        }

        private void Registro_Rol_Load(object sender, EventArgs e)
        {

        }
    }
}
