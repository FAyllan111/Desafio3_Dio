using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Celular.Models
{
    //herdar da classe smartphone
    public class IPhone : Smartphone
    {

        // sobrescrever o metodo instalar aplicativo -> override
        public IPhone(string numero,string modelo, string imei,int memoria) : base(numero,modelo,imei,memoria)
        {

        }
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando {nomeApp}");
            Console.WriteLine($"{nomeApp} instalado com sucesso");
        }
    }
}