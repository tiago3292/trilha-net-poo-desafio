namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone" (FEITO)
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string iMEI, int memoria) : base(numero, modelo, iMEI, memoria)
        {
            
        }

        // TODO: Sobrescrever o método "InstalarAplicativo" (FEITO)
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no Nokia.");
        }
    }
}