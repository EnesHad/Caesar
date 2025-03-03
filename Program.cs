using System.Text;

namespace Caesar
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Metode met = new Metode();

            string niz = "ABRAKADABRaz";
            int zamik = 3;
            string cripted = met.encript(niz, zamik);
            Console.WriteLine("Enkodiranje niza: " + niz);
            Console.WriteLine("Enkodirano v: " + cripted);

            Console.WriteLine("\nDekodiranje niza: " + cripted);
            Console.WriteLine("Enkodirano v: " + met.decode(cripted, zamik));

        }
    }
}