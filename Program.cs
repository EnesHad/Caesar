using System.Text;

namespace Caesar
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Metode met = new Metode();

            Console.WriteLine("Vpiši text ki ga želiš zakodirati");
            string niz = Console.ReadLine();
            Console.WriteLine("\nVpiši številko zamika abecede");
            int zamik = int.Parse(Console.ReadLine());

            string cripted = met.encript(niz, zamik);

            Console.WriteLine("\nEnkodiranje niza: " + niz);
            Console.WriteLine("Enkodirano v: " + cripted);

            Console.WriteLine("\nDekodiranje niza: " + cripted);
            Console.WriteLine("Enkodirano v: " + met.decode(cripted, zamik));

        }
    }
}