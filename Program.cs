using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace while_forEach
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("> bir sayı giriniz: ");
            int sayi = int.Parse(Console.ReadLine());
            int toplam = 0;
            int sayac = 0;
            while(sayac <=sayi){
                toplam+=sayac;
                sayac++;
            }
            Console.WriteLine(toplam/sayi);

           string[] array = new String[6] {"Ankara","İstanbul","İzmir","Adana","Sivas","Hatay"};
           foreach(var n in array){
            Console.WriteLine(n);
           }
        }
    }
}