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

        public static void Main(string[] args)
        {
            
            Controlador C1 = new Controlador();
            Console.WriteLine("Bienvenido a VentaRepuestos");
            while (C1.Flag)
            {
                MostrarMenu();
                EjecutarMenu(C1, C1.ValidaNumerico(Console.ReadLine()));
            }
        }

        static void MostrarMenu()
        {

            Console.WriteLine("Ingrese la opción deseada: " + Environment.NewLine +
                "1 - Agregar Repuesto" + Environment.NewLine +
                "2 - Eliminar Repuesto" + Environment.NewLine +
                "3 - Modificar Precio" + Environment.NewLine +
                "4 - Agregar Stock" + Environment.NewLine +
                "5 - Quitar Stock" + Environment.NewLine +
                "6 - Traer por Categoria" + Environment.NewLine);
        }
        //AgregarRepuesto(Repuesto):void
        static void EjecutarMenu(Controlador C, int i)
        {
            Repuesto R = new Repuesto(1, "martillo", 100, 10);
            switch (i)
            {
                case 1: 
                    AgregarRepuesto(C, R);
                    break;
                case 2:
                    Console.Write("Ingrese el código a eliminar: ");
                    QuitarRepuesto(C, C.ValidaNumerico(Console.ReadLine()));
                    break;
                default: break;
            }
        }
        static void AgregarRepuesto(Controlador C, Repuesto R)
        {
            Console.WriteLine(C.AgregarObj(R) + Environment.NewLine);

        }

        //QuitarRepuesto(int):void
        static void QuitarRepuesto(Controlador C, int i)
        {
            Console.WriteLine(C.EliminarObj(i) + Environment.NewLine);

        }
        //ModificarPrecio(int,double):void
        //AgregarStock(int,int):void
        //QuitarStock(int,int):void
        //TraerPorCategoria(int):List<Repuesto>

    }
}
