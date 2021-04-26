using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VentaRepuestos.Libreria.Entidades;
using VentaRepuestos.Libreria;

namespace VentaRepuestos.Consola
{
    public class VentaRepuestos
    {
        
        static void Main(string[] args)
        {
            Repuesto R = new Repuesto(1, "martillo", 100, 10);
            
            
            AgregarRepuesto(R);


            //R.Codigo(int cod, string nom, double pre, int sto, Categoria cat)
        }

        //AgregarRepuesto(Repuesto):void
        static void AgregarRepuesto(Repuesto R)
        {
            Controlador C = new Controlador();
            C.AgregarObj(R);
        }
        //QuitarRepuesto(int):void
        //ModificarPrecio(int,double):void
        //AgregarStock(int,int):void
        //QuitarStock(int,int):void
        //TraerPorCategoria(int):List<Repuesto>
        
    }
}
