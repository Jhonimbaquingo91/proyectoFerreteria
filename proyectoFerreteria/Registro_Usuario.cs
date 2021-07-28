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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            login lg = new login();
            lg.Show();
        }

    }
}
