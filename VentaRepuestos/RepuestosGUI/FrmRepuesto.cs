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
    public partial class FrmRepuesto : Form
    {
        private FrmRepuesto _frmRep;
        private Form1 _frm;
        private List<Repuesto> _lista;

        public FrmRepuesto(FrmRepuesto frm)
        {
            this._frmRep = frm;
            InitializeComponent();
        }
        public FrmRepuesto(List<Repuesto> listaRepuestos)
        {
            _lista = listaRepuestos;
            InitializeComponent();
        }

        private void FrmRepuesto_Load(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void btnAgregarRep_Click(object sender, EventArgs e)
        {
            Repuesto r = new Repuesto();
            r.Codigo = Convert.ToInt32(tbCodigo.Text);
            r.Nombre = tbNombre.Text;
            r.Precio = Convert.ToDouble(tbPrecio.Text);
            r.Stock = Convert.ToInt32(tbStock.Text);
            //public Repuesto(int cod, string nom, double pre, int sto/*, Categoria cat*/)
            //{
            //    this.Codigo = cod;
            //    this.Nombre = nom;
            //    this.Precio = pre;
            //    this.Stock = sto;
            //    //this.Categoria = cat;
            //}
            _lista.Add(r);
            
        }
    }
}
