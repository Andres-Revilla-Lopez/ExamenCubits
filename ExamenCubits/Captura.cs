using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ExamenCubits
{
    public partial class Captura : Form
    {
        

        public Captura()
        {
            InitializeComponent();
        }

        private void cmbFechaIn_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbFechaIn_Click(object sender, EventArgs e)
        {

            cmbFechaIn.Items.Add("enero");
            cmbFechaIn.Items.Add("febrero");
            cmbFechaIn.Items.Add("marzo");
            cmbFechaIn.Items.Add("abril");
            cmbFechaIn.Items.Add("mayo");
            cmbFechaIn.Items.Add("junio");
            cmbFechaIn.Items.Add("julio");
            cmbFechaIn.Items.Add("agosto");
            cmbFechaIn.Items.Add("septiembre");
            cmbFechaIn.Items.Add("octubre");
            cmbFechaIn.Items.Add("noviembre");
            cmbFechaIn.Items.Add("diciembre");
        }

        private void cmbDia_Click(object sender, EventArgs e)
        {
            cmbDia.Items.Add(1);
            cmbDia.Items.Add(2);
            cmbDia.Items.Add(3);
            cmbDia.Items.Add(4);
            cmbDia.Items.Add(5);
            cmbDia.Items.Add(6);
            cmbDia.Items.Add(7);
            cmbDia.Items.Add(8);
            cmbDia.Items.Add(9);
            cmbDia.Items.Add(10);
            cmbDia.Items.Add(11);
            cmbDia.Items.Add(12);
            cmbDia.Items.Add(13);
            cmbDia.Items.Add(14);
            cmbDia.Items.Add(15);
            cmbDia.Items.Add(16);
            cmbDia.Items.Add(17);
            cmbDia.Items.Add(18);
            cmbDia.Items.Add(19);
            cmbDia.Items.Add(20);
            cmbDia.Items.Add(21);
            cmbDia.Items.Add(22);
            cmbDia.Items.Add(23);
            cmbDia.Items.Add(24);
            cmbDia.Items.Add(25);
            cmbDia.Items.Add(26);
            cmbDia.Items.Add(27);
            cmbDia.Items.Add(28);
            cmbDia.Items.Add(29);
            cmbDia.Items.Add(30);
            cmbDia.Items.Add(31);

        }

        private void btnBsc_Click(object sender, EventArgs e)
        {

           
        }
    }
}
