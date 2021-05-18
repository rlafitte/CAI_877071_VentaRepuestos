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
        private List<Repuesto> _listaRepuestos;
        
        public Form1()
        {
            InitializeComponent();
            _repuesto = new Repuesto();
            ListaRepuestos = new List<Repuesto>();
        }

        public List<Repuesto> ListaRepuestos { get => _listaRepuestos; set => _listaRepuestos = value; }

        private void txtAgregarRep_Click(object sender, EventArgs e)
        {
            FrmRepuesto frm = new FrmRepuesto(ListaRepuestos);
            // FrmEmpresas frm = new FrmEmpresas(_nuevoEstudioContable);
            frm.Owner = this;
            frm.Show();
            this.Hide();
        }
    }
}
