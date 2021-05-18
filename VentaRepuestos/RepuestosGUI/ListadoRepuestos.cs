using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RepuestosGUI
{
    public partial class ListadoRepuestos : Form
    {
        public ListadoRepuestos(List<VentaRepuestos.Libreria.Entidades.Repuesto> listaRepuestos)
        {
            InitializeComponent();
            lstRepuestos
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }
    }
}
