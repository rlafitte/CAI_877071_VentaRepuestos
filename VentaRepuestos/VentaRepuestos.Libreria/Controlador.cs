using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VentaRepuestos.Libreria;
using VentaRepuestos.Libreria.Entidades;


namespace VentaRepuestos.Libreria
{
    public class Controlador
    {
        public List<Repuesto> _listaProductos/* = new List<Repuesto>()*/;
        private string nombreComercio;
        private string direccion;

        private bool flag=true;
        public bool Flag { get => flag; set => flag = value; }
        public string NombreComercio { get => nombreComercio; set => nombreComercio = value; }
        public string Direccion { get => direccion; set => direccion = value; }

        public Controlador()
        {
            if (_listaProductos is null)
            {
                _listaProductos = new List<Repuesto>();
            }
            Flag = true;
        }
        public string AgregarObj(Repuesto R)
        {

            try
            {
            Repuesto R_aux = new Repuesto();
            R_aux = _listaProductos.SingleOrDefault(o => o.Codigo == R.Codigo);
            
            if (R_aux is null)
            {
                _listaProductos.Add(R);
                 return $"Código {R.Codigo} agregado correctamente.";
            }
            else
            {
                 throw new InvalidOperationException();
            }
            }
            catch /*(NullReferenceException)*/
            {

            }
            return "";
        }
        public string EliminarObj(int i)
        {
            if (i > 0)
            {
                Repuesto R_aux = new Repuesto();
                R_aux = _listaProductos.SingleOrDefault(o => o.Codigo == i);
                if (R_aux != null)
                {
                _listaProductos.Remove(R_aux);
                return $"Registro {R_aux.Codigo} eliminado correctamente.";

                }
            }
            else
            {
                throw new InvalidOperationException();
            }
            return "";
        }
        public int ValidaNumerico(string s)
        {
            int i;
            if (int.TryParse(s, out i))
            {
                return i;
            }
            else
            {
                throw new ValorNoNumerico();
            }
        }
        public double ValidaDouble(string s)
        {
            double d;
            if (double.TryParse(s, out d))
            {
                return d;
            }
            else
            {
                throw new Exception();
            }
        }

        public void ValidaExistencia(int i)
        {
            Repuesto R;
            if (_listaProductos != null)
            {

                try
                {
                    R = _listaProductos.FirstOrDefault(o => o.Codigo == i);
                    if (R.Codigo != null)
                    {
                        throw new Exception();

                    }
                }
                catch (NullReferenceException)
                {

                }
            }
        }
        public Repuesto BuscaProducto(int i)
        {
            Repuesto R = new Repuesto();
            try
            {
                R = _listaProductos.FirstOrDefault(o => o.Codigo == i);
                return R;
            }
            catch
            {
                throw new Exception();
            }
        }
        public void ActualizaPrecio(int i, double d)
        {
            Repuesto R = new Repuesto();
            try
            {
                R = _listaProductos.FirstOrDefault(o => o.Codigo == i);
                if (R!= null)
                {
                    foreach (Repuesto r in _listaProductos)
                    {
                        if (R.Codigo == r.Codigo)
                        {
                            r.Precio = d;
                        }
                    }
                }
            }
            catch
            {
                throw new Exception();
            }
        }
        //public string Listar()
        //{
        //    string msg = "";
        //    foreach (Object obj in _list)
        //    {
        //        msg += (obj.ToString() + Environment.NewLine);
        //    }
        //    return msg;
        //}
        //public string ToString()
        //{
        //    return $"{this.Dato}";
        //}
        //public override bool Equals(object obj)
        //{
        //    Object A = (Object)obj;
        //    if (A.dato == this._dato)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}
    }
}
