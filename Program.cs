using System.Text;

namespace Caesar
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Pridobivanje podatkov
            Console.WriteLine("Vpiši text ki ga želiš zakodirati: ");
            string niz = Console.ReadLine();
            Console.Write("\nVpiši številko zamika abecede (0-25): ");
            int zamik = int.Parse(Console.ReadLine());
            Console.Write("\nVpiši številko dinamičnega zamika (0-25): ");
            int dim_zamik = int.Parse(Console.ReadLine());

            //Konstruktor za metode
            Metode met = new Metode();

            //Kriptiranje
            string cripted = met.encript(niz, zamik, dim_zamik);
            //Izpisi
            Console.WriteLine("\nEnkodiranje niza: " + niz);
            Console.WriteLine("Enkodirano v: " + cripted);

            //Dekriptanje
            string decripted = met.decode(cripted, zamik, dim_zamik);
            //Izpis
            Console.WriteLine("\nDekodiranje niza: " + cripted);
            Console.WriteLine("Enkodirano v: " + decripted);

        }
    }
}