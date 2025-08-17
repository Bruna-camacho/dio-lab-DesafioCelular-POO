using System;

namespace DesafioCelular
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criando um celular Samsung S24Ultra
            S24Ultra s24 = new S24Ultra();
            s24.TemInternet = true;
            s24.TemCamera = true;
            s24.TemSmartThings = true;
            s24.TemTelaAntiReflexo = true;

            Console.WriteLine("S24 Ultra:");
            s24.FazerChamada();
            s24.AbrirSmartThings();
            Console.WriteLine($"Tem Internet? {s24.TemInternet}");
            Console.WriteLine($"Tem câmera? {s24.TemCamera}");
            Console.WriteLine($"Tem SmartThings? {s24.TemSmartThings}");
            Console.WriteLine($"Tem tela anti-reflexo? {s24.TemTelaAntiReflexo}");
            Console.WriteLine();

            // Criando um celular Motorola Edge50
            Edge50 edge50 = new Edge50();
            edge50.TemInternet = true;
            edge50.TemCamera = true;
            edge50.TemCarregamentoTurboPower = true;
            edge50.TemMotoGestos = true;
            edge50.TemSensorDigitalNaTela = true;

            Console.WriteLine("Edge 50:");
            edge50.FazerChamada();
            edge50.AtivarMotoGestos();
            Console.WriteLine($"Tem Internet? {edge50.TemInternet}");
            Console.WriteLine($"Tem câmera? {edge50.TemCamera}");
            Console.WriteLine($"Tem carregamento Turbo Power? {edge50.TemCarregamentoTurboPower}");
            Console.WriteLine($"Tem Moto Gestos? {edge50.TemMotoGestos}");
            Console.WriteLine($"Tem sensor digital na tela? {edge50.TemSensorDigitalNaTela}");
        }
    }
}
