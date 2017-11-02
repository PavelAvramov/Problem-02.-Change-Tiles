using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Плочки
{
    class Program
    {
        static void Main(string[] args)
        {
           
            double СъбраниПари = double.Parse(Console.ReadLine());
            double ШирочинаПод = double.Parse(Console.ReadLine());
            double ДължинаПод = double.Parse(Console.ReadLine());
            double СтранаТриъгълник = double.Parse(Console.ReadLine());
            double ВисочинаТриъгълник = double.Parse(Console.ReadLine());
            double ЦенаПлочка = double.Parse(Console.ReadLine());
            double СумаМайстор = double.Parse(Console.ReadLine());

            double ПлощПод = ШирочинаПод * ДължинаПод;
          //  Console.WriteLine(ПлощПод);

            double ПлощПлочка = (СтранаТриъгълник *ВисочинаТриъгълник)/2;
        //    Console.WriteLine(ПлощПлочка);

            double НеобходимиПлочки = Math.Ceiling(ПлощПод / ПлощПлочка) + 5;
            //     Console.WriteLine(НеобходимиПлочки);

            double ОбщаСума = НеобходимиПлочки * ЦенаПлочка + СумаМайстор;
            double ОставащиПари = СъбраниПари - ОбщаСума;
            double НедостигащиПари = ОбщаСума - СъбраниПари;
            if (ОбщаСума<=СъбраниПари)
            {
                Console.WriteLine("{0:f2} lv left.",ОставащиПари);
            }
          else
            {
                Console.WriteLine("You'll need {0:f2} lv more.",НедостигащиПари);
            }

        }
    }
}
