using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] humanParavetrs = new string[4];
            string[] ask = new string[] { "Как вас зовут?", "Сколько вам лет?", "Где вы работаете?", "Какое у вас образование?" };
            
            for (int i = 0; i <= (humanParavetrs.Length - 1); i++)
            {
                Console.WriteLine(ask[i]);
                humanParavetrs[i] = Console.ReadLine();
            };

            Console.WriteLine("Имя - " + "\t\t" + humanParavetrs[0]);
            Console.WriteLine("Возраст - " + "\t" + humanParavetrs[1]);
            Console.WriteLine("Работа - " + "\t" + humanParavetrs[2]);
            Console.WriteLine("Образование - " + "\t" + humanParavetrs[3]);
            Console.ReadLine();
        }
    }
}
