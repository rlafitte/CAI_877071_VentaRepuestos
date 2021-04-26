using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentaRepuestos.Libreria.Entidades
{
    public class Repuesto : Categoria
    {
        private int _codigo;
        private string _nombre;
        private double _precio;
        private int _stock;
        private Categoria _categoria;
        public Repuesto()
        {

        }
        public Repuesto(int cod, string nom, double pre, int sto/*, Categoria cat*/)
        {
            this.Codigo = cod;
            this.Nombre = nom;
            this.Precio = pre;
            this.Stock = sto;
            //this.Categoria = cat;
        }

        public string ToString()
        {
            return $"{this.Codigo} - {this.Nombre} - ${this.Precio} - Stock disponible: {this.Stock}";
        }
        public int Codigo1 { get => _codigo; set => _codigo = value; }
        public string Nombre1 { get => _nombre; set => _nombre = value; }
        public double Precio { get => _precio; set => _precio = value; }
        public int Stock { get => _stock; set => _stock = value; }
        public Categoria Categoria { get => _categoria; set => _categoria = value; }
    }
}
