using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Celular.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set}
        protected string Modelo{ get; set; }
        protected string IMEI{ get; set; }
        protected int Memoria{ get; set; }

        // implementar classes faltantes de acordo com o diagrama -ok

        public Smartphone(string numero,string modelo,string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria; 
            // construtor para as outras propriedades
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigação()
        {
            Console.WriteLine("Recebendo ligação...")
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}