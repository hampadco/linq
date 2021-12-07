using System;
using System.Linq;
using System.Collections.Generic;
using System.Globalization;

namespace sample1
{
    class Program
    {
        static void Main(string[] args)
        {
               System.Console.WriteLine("please enter price:");
               int price=int.Parse(Console.ReadLine());

               System.Console.WriteLine("price:"+price.torial());
               DateTime a=DateTime.Now;
               System.Console.WriteLine(a.toshamsi());


                  
              

        }
    }

    static class myclass
    {
        public static string torial(this int p)
        {
            return p.ToString("#,0");
        }


        public static string toshamsi(this DateTime s)
        {
            PersianCalendar pr=new PersianCalendar();
            string shamsi=pr.GetYear(s).ToString()+"/"+pr.GetMonth(s).ToString("00")+"/"+pr.GetDayOfMonth(s).ToString("00");
             return shamsi;
        }

    }
}
