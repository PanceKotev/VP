using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab15
{
    enum PasswordStrength : int
    {
        easy=1,
        normal=2,
        hard=3,
        unknown=4
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Na koja teskost sakas da pogoduvas password?(easy,normal,hard)\n");
            string izb= Console.ReadLine();
            PasswordStrength izbor;
            if (izb.Equals("easy"))
                izbor = PasswordStrength.easy;
            else if (izb.Equals("normal"))
                izbor = PasswordStrength.normal;
            else if (izb.Equals("hard"))
                izbor = PasswordStrength.hard;
            else
                izbor = PasswordStrength.unknown;
            string rand = generatePassword(izbor);
            Console.WriteLine(rand);
            string passLine = Console.ReadLine();
            char[] delimiter = { ' ' };
            string[] parts = passLine.Split(delimiter);
            bool tocno = false;
            foreach(string del in parts)
            {
                if(del.Equals(rand))
                {
                    tocno = true;
                    break;
                }

            }
            if (tocno)
                Console.WriteLine("Bravo! ja pogodivte lozinkata {0} ", rand);
            else
                Console.WriteLine("Ne ja pogodivte lozinkata {0}",rand);
            Console.ReadLine();


        }
        static string generatePassword(PasswordStrength passwordStrength)
        {
            int sila = (int)passwordStrength;
            Random random = new Random();
            string pogodi = "";
            if (sila == 1) {
                char[] source = "abcdefghijklmnoprqstuvwxyz".ToCharArray();
                int n = random.Next(1, 6);
                for (int i = 0; i < n; i++)
                {
                    pogodi += source[random.Next(0, source.Length-1)];
                }
            }
            else if (sila == 2)
            {
               char[] source= "abcdefghijklmnoprqstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789".ToCharArray();
                int n = random.Next(6, 10);
                for(int i = 0; i < n; i++)
                {
                    pogodi += source[random.Next(0, source.Length-1)];
                }
            }
            else if (sila == 3)
            {
                char[] source = "abcdefghijklmnoprqstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!?@#$%^&*()_+-=][;,.\\/`~<>".ToCharArray();
                int n = random.Next(10, 25);
                for (int i = 0; i < n; i++)
                {
                    pogodi += source[random.Next(0, source.Length - 1)];
                }
            }
            return pogodi;
        }
    }
}
