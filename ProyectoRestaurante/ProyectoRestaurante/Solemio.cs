using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoRestaurante
{
    class Solemio
    {
        public void mostrar()
        {
            Menu();
        }
        public async Task Menu()
        {
            int a;
            int timeAS=0, timeS=0;
            string text1AS=" ", text2AS=" ", text3S=" ", text1S=" ", text2S=" ";
            do
            {
                
                Console.WriteLine("OPCIONES:");
                Console.WriteLine("1: Mostrar Menu");
                Console.WriteLine("2: Limpiar Mesa");
                Console.WriteLine("3: Pedir Comida");
                var opc = Convert.ToInt32(Console.ReadLine());
                a = opc;
                switch (opc)
                {
                    case 1:
                        //Console.Clear();
                        var devs = Platos();
                        var groupname = devs.GroupBy(n => n.Nombre);
                        Console.WriteLine("                                                    MENU");
                        foreach (var nom in devs)
                        {
                            Console.WriteLine(nom.GetPlatillos());
                        }
                        Console.WriteLine("Introduzca su nombre par aresivir el platillo:");
                        string nombreDelCliente = Console.ReadLine();
                        Console.WriteLine("Introduzca el platillo que desea:");
                        int tipoDePlato = int.Parse(Console.ReadLine());
                        switch (tipoDePlato)
                        {
                            case 1:
                                text1AS = "Se pone la Pizza con todos los ingredientes al horno";
                                text2AS = "Se saca la pizza cocinada del horno";
                                
                                text1S = "rter";
                                text2S = "uty";
                                text3S = "wq";
                                timeAS = 5000;
                                timeS = 1000;
                                break;
                            case 2:
                                text1AS = "adwa";
                                text2AS = "a";
                                
                                text1S = "rr";
                                text2S = "ut";
                                text3S = "q";
                                timeAS = 5000;
                                timeS = 1000;
                                break;

                        }

                        Chef.Orden(text1AS, text2AS, text1S, text2S, text3S, timeAS, timeS, nombreDelCliente);
                        //Console.ReadKey();
                        break;
                    case 2:
                        Mesero.LimpiaMesa();
                        break;
                }
            }
            while (a != 4);
        }

        public static List<Platillos> Platos()
        {
            var comida = new List<Platillos>();
            comida.Add(new Platillos() { Nombre = "Sole mio", Descripcion = "Salsa de tomate, queso mozzarella, jamon, champinones, aceitunas verdes y huevo", PrecioG = 85, PrecioP = 65 });
            comida.Add(new Platillos() { Nombre = "Rustica", Descripcion = "Salsa de tomate, queso mozzarella, champinones y berenjenas", PrecioG = 75, PrecioP = 60 });
            comida.Add(new Platillos() { Nombre = "Rio mare", Descripcion = "Salsa de tomate, queso mozzarella, atun y cebolla", PrecioG = 80, PrecioP = 75 });
            comida.Add(new Platillos() { Nombre = "Ortolana", Descripcion = "Salsa de tomate, queso mozzarella, pimenton, cebolla y aceitunas negras", PrecioG = 70, PrecioP = 55 });
            comida.Add(new Platillos() { Nombre = "Funghi porcini", Descripcion = "Salsa de tomate, queso mozzarella y hongos porcini", PrecioG = 90, PrecioP = 70 });
            comida.Add(new Platillos() { Nombre = "Diavola", Descripcion = "Salsa de tomate, queso mozzarella, salame y aji", PrecioG = 70, PrecioP = 55 });
            return comida;
        }
    }
}
