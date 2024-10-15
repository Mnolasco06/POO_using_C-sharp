using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smartphone
{
    internal abstract class Smartphone
    {
        public string Numero;
        private string Modelo;
        private string IMEI;
        private int Memoria;


        public void Ligar() 
        {

            Console.WriteLine("Ligando....");
        }

        public void ReceberLigacao() 
        {

            Console.WriteLine("Recebendo ligação de....."); 
        }

        public abstract void InstalarAplicativo();

    }
}
