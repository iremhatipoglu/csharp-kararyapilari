using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kararYapilariPatika
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /********** Patika C# Modülü Karar Yapıları Ders Notları **********/


            int time = DateTime.Now.Hour;

            if (time >= 6 && time < 12)
            {
                Console.WriteLine("Günaydın");
            }
            else if (time > 11 && time < 18)
            {
                Console.WriteLine("İyi günler");
            }
            else if (time >= 18 && time <= 21)
            {
                Console.WriteLine("İyi akşamlar");
            }
            else
            {
                Console.WriteLine("İyi geceler");
            }

            /*******************************************************************/

            string sonuc;

            sonuc = time >= 6 && time < 12 ? "Günaydın" : time > 11 && time < 18 ?
                "İyi günler" : time >= 18 && time <= 21 ? "İyi akşamlar" : "İyi geceler";
            Console.WriteLine(sonuc);


        }
    }
}
