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
    public partial class agregarHerramienta : Form
    {
        public agregarHerramienta()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            if (txt_nom.Text == ""
                && txt_precio.Text == "" 
                && txt_cantidad.Text == "" 
                && txt_id_prov.Text == "")
            {
                MessageBox.Show("Favor llenar los campos");
                txt_nom.Text = "";
                txt_precio.Text = "";
                txt_cantidad.Text = "";
                txt_id_prov.Text = "";


            }
            else
            {

                this.Hide();
                new Inicio().ShowDialog();

            }

        }

        private void agregarHerramienta_Load(object sender, EventArgs e)
        {

        }
    }
}
