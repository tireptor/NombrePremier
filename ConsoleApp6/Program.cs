using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Nombre premier
namespace ConsoleApp6
{
    class Program
    {
        // Vérifie si le nombre passé en paramètre est premier
        public static bool estPremier(int nb)
        {
            if (nb < 2)
            {
                return false;
            }
            if (nb == 2)
            {
                return true;
            }
            if (nb % 2 == 0)
            {
                return false;
            }
            int i;
            i = 3;
            while ((i * i <= nb))
            {
                if (nb % i == 0)
                {
                    return false;
                }
                else
                {
                    i = i + 1;
                }
            }
            return true;
        }

        public static string listeDiviseur(int nb)
        {
            string sh = "Liste des diviseurs : ";
            for (int i = nb; i != 0; i--)
            {
                if (nb % i == 0)
                {
                    sh += i +" ; ";
                }
            }
            return sh;
        }

        static void Main(string[] args)
        {
            int[] numberArray = new int[] { 1, 3, 5, 7, 9 ,10,100,110};
            string sh = "";
            foreach (int number in numberArray)
            {
                if (estPremier(number))
                {
                    sh += number+" est premier " + "\n";
                }
                else
                {
                    sh += number + " n'est pas premier ";
                    sh += listeDiviseur(number)+"\n";
                }
            }
            Console.WriteLine(sh);
            Console.ReadKey();
        }
    }
}
