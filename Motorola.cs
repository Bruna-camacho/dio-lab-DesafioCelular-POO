using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioCelular
{
    public class Motorola: Celular
    {
        public bool TemCarregamentoTurboPower { get; set; }
        public bool TemMotoGestos { get; set; }

        public void AtivarMotoGestos()
        {
            Console.WriteLine("Ativar a funcionalidade Moto gestos");
        }
        
    }
}