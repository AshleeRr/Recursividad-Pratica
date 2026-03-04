namespace Calculo_de_depreciacion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese los datos:");
            Console.WriteLine("Cantidad de años");
            int tiempo = ValidarTiempo(int.Parse(Console.ReadLine()!));

            Console.WriteLine("tasa de depreciacion anual");
            decimal tasa = decimal.Parse(Console.ReadLine()!);
            Console.WriteLine("costo original del producto");
            decimal costoOriginal = decimal.Parse(Console.ReadLine()!);
             
            decimal valorActual  = SaldoDecreciente(tiempo, tasa, costoOriginal);
            Console.WriteLine("Valor del activo en el ultimo año: " + Math.Round(valorActual,2));
        }

        static decimal SaldoDecreciente(int tiempo, decimal tasa, decimal costoOriginal)
        {   
            if (tiempo == 0)
                return costoOriginal;

            decimal factorRetencion = 1 - (tasa / 100);
            return SaldoDecreciente(tiempo - 1,tasa, costoOriginal) * factorRetencion;
        }

        static int ValidarTiempo(int t)
        {
            if (t > 0)
                return t;

            Console.WriteLine("La cantidad de tiempo no puede ser negativa");
            return ValidarTiempo(int.Parse(Console.ReadLine()!));
        }
    }
}
