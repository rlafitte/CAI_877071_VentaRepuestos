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
            //Repuesto R = new Repuesto(1, "martillo", 100, 10);
            switch (i)
            {
                case 1: 
                    AgregarRepuesto(C, DatosRepuesto());
                    break;
                case 2:
                    Console.Write("Ingrese el código a eliminar: ");
                    QuitarRepuesto(C, C.ValidaNumerico(Console.ReadLine()));
                    break;
                case 3:
                    Repuesto R = new Repuesto();
                    Repuesto R_aux = new Repuesto();
                    Console.Write("Ingrese código de repuesto a modificar el precio: ");
                    R_aux.Codigo = C.ValidaNumerico(Console.ReadLine());
                    R = C.BuscaProducto(R_aux.Codigo);
                    Console.Write("El precio actual es $" + R.Precio + ". Indique el nuevo precio: ");
                    ModificarPrecio(C, R.Codigo, C.ValidaDouble(Console.ReadLine()));                    

                    break;

                default: break;
            }
        }
        static void AgregarRepuesto(Controlador C, Repuesto R)
        {
            Console.WriteLine(C.AgregarObj(R) + Environment.NewLine);

        }
        static Repuesto DatosRepuesto()
        {
            Repuesto R = new Repuesto();
            Controlador C_aux = new Controlador();
            Console.Write("Ingrese código de repuesto: ");
            R.Codigo = C_aux.ValidaNumerico(Console.ReadLine());
            Console.Write("Ingrese nombre de repuesto: ");
            R.Nombre = Console.ReadLine();
            Console.Write("Ingrese el valor: ");
            R.Precio = C_aux.ValidaDouble(Console.ReadLine());
            Console.Write("Ingrese el stock: ");
            R.Stock = C_aux.ValidaNumerico(Console.ReadLine());
            return R;

        }

        //QuitarRepuesto(int):void
        static void QuitarRepuesto(Controlador C, int i)
        {
            Console.WriteLine(C.EliminarObj(i) + Environment.NewLine);

        }
        //ModificarPrecio(int,double):void
        static void ModificarPrecio(Controlador C, int i, double d)
        {
            Repuesto R = new Repuesto();
            Repuesto R_aux = new Repuesto();
            R = C.BuscaProducto(R_aux.Codigo);
            double.TryParse(Console.ReadLine(), out d);
            if (d != null)
            {
                C.ActualizaPrecio(R.Codigo, d);
                Console.WriteLine("Precio modificado");
            }
            else
            {
                Console.WriteLine("No fue posible modificar el precio");
            }


        }
        //AgregarStock(int,int):void
        //QuitarStock(int,int):void
        //TraerPorCategoria(int):List<Repuesto>

    }
}
