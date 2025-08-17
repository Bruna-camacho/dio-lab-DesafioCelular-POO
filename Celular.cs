using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioCelular
{
    public class Celular
    {
        public bool TemInternet { get; set; }
        public bool TemBluetooth { get; set; }
        public bool TemCamera { get; set; }

        public void FazerChamada()
        {
            Console.WriteLine("Realizando chamada telefônica");
        }
    }
}