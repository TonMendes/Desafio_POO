using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Celular_POO.Entities
{
    public abstract class Smartphone
    {
        protected Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }

        public string Numero {  get; set; } = string.Empty;
        readonly string Modelo; 
        readonly string IMEI;
        readonly int Memoria;

        public virtual void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public virtual void ReceberLigacao()
        {
            Console.WriteLine("Recebendo Ligação");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}
