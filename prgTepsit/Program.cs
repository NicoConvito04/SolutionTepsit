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
                numero = numero / 16;
                numeroConvertito = Convert.ToString(resto) + numeroConvertito;
                if (resto > 9)
                {
                    if (resto == 10)
                    {
                        numeroConvertito = "A" + numeroConvertito;
                    }
                    else if (resto == 11)
                    {
                        numeroConvertito = "B" + numeroConvertito;
                    }
                    else if (resto == 12)
                    {
                        numeroConvertito = "C" + numeroConvertito;
                    }
                    else if (resto == 13)
                    {
                        numeroConvertito = "D" + numeroConvertito;
                    }
                    else if (resto == 14)
                    {
                        numeroConvertito = "E" + numeroConvertito;
                    }
                    else if (resto == 15)
                    {
                        numeroConvertito = "F" + numeroConvertito;
                    }
                    else
                    {
                        numeroConvertito = Convert.ToString(resto) + numeroConvertito;
                    }
                }
            }
            Console.WriteLine($"Il numero convertito è {numeroConvertito}");
            Console.ReadLine();
        }
    }
}
