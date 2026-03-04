namespace Interes_Compuesto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserte los datos:");
            Console.WriteLine("Cantidad de años transcurridos:");
            int tiempo = int.Parse(Console.ReadLine()!);

            Console.WriteLine("Capital inicial:");
            decimal capitalInicial = decimal.Parse(Console.ReadLine()!);

            Console.WriteLine("Tasa de interes anual:");
            decimal TasaInteresAnual = decimal.Parse(Console.ReadLine()!);

            decimal montoAcumulado = CalcularMontoTotalAcumulado(capitalInicial, TasaInteresAnual, tiempo);
            Console.WriteLine("Monto total acumulado: " + Math.Round(montoAcumulado,2));
        }

        static decimal CalcularMontoTotalAcumulado(decimal m, decimal x, int n)
        {
            if (n == 0)
                return m;

            decimal interes = x / 100;

            return CalcularMontoTotalAcumulado(m, x, n - 1) * (1 + interes);
        }
    }
}
