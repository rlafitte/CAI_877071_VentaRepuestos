using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VentaRepuestos.Libreria.Entidades;

namespace RepuestosGUI
{
    public partial class Form1 : Form
    {
        private Repuesto _repuesto;
        public Form1()
        {
            InitializeComponent();
            _repuesto = new Repuesto(); 
        }

        private void txtAgregarRep_Click(object sender, EventArgs e)
        {
            FrmRepuesto frm = new FrmRepuesto();
            // FrmEmpresas frm = new FrmEmpresas(_nuevoEstudioContable);
            frm.Owner = this;
            frm.Show();
            this.Hide();
        }
    }
}
