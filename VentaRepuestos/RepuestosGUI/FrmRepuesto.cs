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


        public FrmRepuesto(FrmRepuesto frm)
        {
            this._frmRep = frm;
            InitializeComponent();
        }
        public FrmRepuesto()
        {
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
    }
}
