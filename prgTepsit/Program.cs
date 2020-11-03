using System;

namespace prgTepsit
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int resto;
            string numeroConvertito = "";
            int divisore;

            Console.WriteLine("Inserisci un numero");
            numero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Inserisci divisore");
            divisore = Convert.ToInt32(Console.ReadLine());
            while (numero != 0)
            {

                resto = numero % divisore;
                numero = numero / 8;
                numeroConvertito = Convert.ToString(resto) + numeroConvertito;
               
            }
            Console.WriteLine($"Il numero convertito è {numeroConvertito}");
            Console.ReadLine();
        }
    }
}
