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
        public List<Repuesto> _listaProductos = new List<Repuesto>();
        private string nombreComercio;
        private string direccion;

        private bool flag=true;
        public bool Flag { get => flag; set => flag = value; }
        public string NombreComercio { get => nombreComercio; set => nombreComercio = value; }
        public string Direccion { get => direccion; set => direccion = value; }

        public string AgregarObj(Repuesto R)
        {

            try
            {
            Repuesto R_aux = _listaProductos.FirstOrDefault(o => o.Codigo == R.Codigo);
            if (R_aux.Codigo == null)
            {
                _listaProductos.Add(R);
                 return $"Código {R.Codigo} agregado correctamente.";
            }
            else
            {
                 throw new InvalidOperationException();
            }
            }
            catch (NullReferenceException)
            {

            }
            return "";
        }
        //public string EliminarObj(Object obj)
        //{
        //    if (obj != null)
        //        _list.Remove(obj);
        //        return $"Registro {1} eliminado correctamente.";
        //    else
        //        throw new InvalidOperationException();
        //}
        //public int ValidaNumerico(string s)
        //{
        //    int i;
        //    if (int.TryParse(s, out i))
        //    {
        //        return i;
        //    }
        //    else
        //    {
        //        throw new ValorNoNumerico();
        //    }
        //}

        //public void ValidaExistencia(int i)
        //{
        //    object obj;
        //    if (_list != null)
        //    {

        //    try
        //    {
        //        obj = _list.FirstOrDefault(o => o.dato == i);
        //        if (aux.Codigo != null)
        //        {
        //            throw new Exception();

        //        }
        //    }
        //    catch (NullReferenceException)
        //    {

        //    }
        //    }
        //}
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
