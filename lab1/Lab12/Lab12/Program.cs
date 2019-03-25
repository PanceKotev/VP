using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Napisete kolku broevi sakate da vnesuvate");
            int n = Convert.ToInt32(Console.ReadLine());
            Random random = new Random();
            Console.WriteLine("Dali sakate na random ili sakate da vnesuvate broevi? (random za random, ne za vnesuvanje)");
            string izbor=Console.ReadLine().ToLower();
            bool tocno = true;
            int[] broevi = new int[n];
                for (int i = 0; i < n; i++)
                {
                if (izbor.Equals("ne")) {
                    Console.Write("{0}: ", i + 1);
                    broevi[i] = Convert.ToInt32(Console.ReadLine()); }
                else if(izbor.Equals("random"))
                {
                    broevi[i] = random.Next(1, 1000);
                   Console.Write("{0}: {1} \n",i + 1,broevi[i]);
                }
                else
                {
                    Console.Write("Vnesovte nevaliden izbor\n");
                    tocno = false;
                    break;
                }
                }
            int min = 0;
            minbroj(broevi, out min);
            int max = 0;
            maxbroj(broevi, out max);
            if (tocno)
            {
                Console.WriteLine("Srednata vrednost e: {0:0.00}\n", Srednavred(broevi));
                Console.WriteLine("Najgolemiot broj e: {0}\n",min );
                Console.WriteLine("Najmaliot broj e: {0}\n",max);
            }
            Console.ReadLine();
        }
        static double Srednavred( int[] br)
        {
            double zbir = 0;
            foreach(int b in br)
            {
                zbir += b;
            }
            zbir = zbir/br.Length;
            return zbir;
        }
        static void minbroj(int[] br,out int min)
        {
            min = Int32.MaxValue;
            foreach(int b in br)
            {
                if (min > b)
                    min = b;
            }
        }
        static void maxbroj(int[] br,out int max)
        {
            max = Int32.MinValue;
            foreach (int b in br)
            {
                if (max < b)
                   max = b;
            }
        }
    }
}
