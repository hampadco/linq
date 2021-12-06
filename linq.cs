using System;
using System.Linq;
using System.Collections.Generic;

namespace sample1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] number =new int[]{6,5,8,0,12,80,3};
            
            //max
            int max=0;
            foreach (var item in number)
            {
                if (max< item)
                {
                    max=item;
                }
            }
          
         // Console.WriteLine(max);

          //max by linq

          var maximum=(from n in number select n ).Max();
          Console.WriteLine(maximum);

          //min by linq
          var min =(from x in number select x).Min();
          Console.WriteLine(min);
          
          
          //avrage by linq
          var avg=(from n in number select n).Average();
          Console.WriteLine(avg);
          //sum by Linq 
          var sum=(from n in number select n).Sum();
          Console.WriteLine(sum);
          //count by linq
          var count =(from n in number select n).Count();
          Console.WriteLine(count);
          // take
          var s=(from n  in number select n).Take(2).ToArray();
          foreach (var item in s)
          {
              Console.WriteLine(item);
              
          }
          ////skip 
          Console.WriteLine("*******");
          
          var sk=(from n in number select n).Skip(3).ToArray();
          foreach (var item in sk)
          {
              Console.WriteLine(item);
              
          }
          ///pagenin by take and skip by linq
          int p=0;
          var paging=(from n in number select n).Skip((p-1)*2).Take(2).ToArray();
         //where by linq   
        Console.WriteLine("where****************");
        
         var g=(from n in number where n>8 select n).ToArray();
         foreach (var item in g)
         {
             Console.WriteLine(item);
             
         } 

         ///list by use linq
          List<string> name=new List<string>()
          {"ali","AhmAd","rahim","sara","amin"};
          var b=(from n in name where n.ToLower().Contains("a") select n).ToList();
          foreach (var item in b)
          {
            Console.WriteLine(item);
             
          }
          
            

        }
    }
}
