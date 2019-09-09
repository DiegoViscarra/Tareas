using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProyectoRestaurante
{
    public class Chef
    {
        public static async Task Orden(string text1AS, string text2AS, string text1S, string text2S, string text3S, int timeAS, int timeS, string nombreDelCliente)
        {
             TestChefAsync(text1AS, text2AS, text1S, text2S, text3S, timeAS, timeS, nombreDelCliente);
        }

        public async static Task TestChefAsync(string text1AS, string text2AS, string text1S, string text2S, string text3S, int timeAS, int timeS, string nombreDelCliente)
        {
            //Console.Clear();
            var chef = new ChefAsync();
            //var platoEntregaAsync = chef.Recibir(nombre);
            var chefSincrono = chef.PrepareMediaSyncFunction(text1S, text2S, text3S, timeS );
            
            Thread.Sleep(1000);
            var platoEntregaAsync = chef.PrepareMediaAsyncFunction(text1AS, text2AS, nombreDelCliente, timeAS);
            //var pedido = await meseroEntrega;
            var platoEntrega = await platoEntregaAsync;
            Console.WriteLine($"{platoEntrega} : Lista");
        }
        public class ChefAsync
        {
            public async Task<string> Recibir(string nombre)
            {
                string respuesta = "La pizza de la familia " + nombre;
                await Task.Run(() =>
                {
                    Console.WriteLine("Comida Pedida");
                    Thread.Sleep(10000);
                    Console.WriteLine("Preparando Comida");
                });
                
                return respuesta;
            }
            public string PrepareMediaSyncFunction(string txt1, string txt2, string txt3, int clockRate)
            {
                Console.WriteLine(txt1);
                Thread.Sleep(clockRate);
                Console.WriteLine(txt2);
                return txt3;
            }
            public async Task<string> PrepareMediaAsyncFunction(string txt1, string txt2, string nombre, int clockRate)
            {
                string respuesta = "La pizza de la familia " + nombre;
                await Task.Run(() =>
                {
                    Console.WriteLine(txt1);    
                    Thread.Sleep(clockRate);
                    Console.WriteLine(txt2);
                });

                return respuesta;
            }
        }
    }
}
