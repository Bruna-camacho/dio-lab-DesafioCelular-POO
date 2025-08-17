using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioCelular
{
    public class Samsung : Celular
    {
        public bool TemSmartThings { get; set; }
        public bool TemTelaAmoled { get; set; }

        public void AbrirSmartThings()
        {
            Console.WriteLine("Abrindo o aplicativo SmartThings");
        }
        
    }
}