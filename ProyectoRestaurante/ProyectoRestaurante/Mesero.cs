using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProyectoRestaurante
{
    public static class Mesero
    {
        public static void LimpiaMesa()
        {
           // Console.Clear();
            var limpiar = new Limpiar();
            limpiar.PutChickenInTheOven();
        }
        public class Limpiar
        {
            public void PutChickenInTheOven()
            {
                Console.WriteLine("Mesero limpiando la mesa");
                Thread.Sleep(2000);
                Console.WriteLine("Mesa limpiada");
                Console.ReadKey();
            }
        }
    }
}
