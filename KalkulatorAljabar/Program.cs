using AljabarLibraries;

namespace KalkulatorAljabar
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Akar persamaan dari x^2 - 3x - 10 adalah: ");
            Console.WriteLine(String.Join(", ", Aljabar.AkarPersamaanKuadrat(new double[] { 1, -3, -10 })));


            Console.Write("Hasil kuadrat dari (a + b)^2 adalah: ");
            Console.WriteLine(String.Join(", ", Aljabar.HasilKuadrat(new double[] { 2, -3 })));
        }
    }
}
