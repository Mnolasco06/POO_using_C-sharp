using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smartphone
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Nokia meuNokia = new Nokia();
            Iphone meuIphone = new Iphone();


            Console.WriteLine("testando o metodo instalar app");

            meuNokia.InstalarAplicativo();

            Console.WriteLine("---------------------------------------------");

            Console.WriteLine("testando o metodo Ligar");

            meuNokia.Ligar();

            Console.WriteLine("---------------------------------------------");

            Console.WriteLine("testando o metodo receberligacao");

            meuNokia.ReceberLigacao();

            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("---------------------------------------------");

            Console.WriteLine("Usando os metodos do meu Iphone");

            Console.WriteLine("testando o metodo instalar app");

            meuIphone.InstalarAplicativo();

            Console.WriteLine("---------------------------------------------");

            Console.WriteLine("testando o metodo Ligar");

            meuIphone.Ligar();

            Console.WriteLine("---------------------------------------------");

            Console.WriteLine("testando o metodo receberligacao");

            meuIphone.ReceberLigacao();

        }
    }
}
