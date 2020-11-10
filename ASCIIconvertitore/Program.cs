using System;

namespace ASCIIconvertitore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("inserisci una lettere di cui vuoi sapere in numero in ASCII");
            char carattere = Convert.ToChar(Console.ReadLine());
            ushort carattereinASCII = 0;
            carattereinASCII = carattere;
            Console.WriteLine(" carattere {0} - carattere in ASCII {1}", carattere, carattereinASCII);
            Console.ReadKey();
        }
    }
}
