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

         
          //max by Lambda
          var maximum=number.Max();
          Console.WriteLine("max:"+maximum);
          

         
          //min by lambda
          var min=number.Min();
          Console.WriteLine("min:"+min);
          
         
          
          
          //avrage by lambda
          var avg=number.Average();
           Console.WriteLine("avg:"+avg);
          
          //sum by lamda
          var sum=number.Sum();
           Console.WriteLine("sum:"+sum); 
          
          //count by lamda
          var count=number.Count();
           Console.WriteLine("Count:"+count);
          
          // take by lambda
          var t=number.Take(2).ToArray();
          foreach (var item in t)
          {
              Console.WriteLine(item);
              
          }
          
          ////skip  by lambda
          var s=number.Skip(3).ToArray();
          foreach (var item in s)
          {
              Console.WriteLine(item);
              
          }
         
          ///pagenin by take and skip by lambda
          int p=0;
          var paging=number.Skip((p-1)*2).Take(2).ToList();


          //where by Lambda
           Console.WriteLine($"where********");
           
          var q=number.Where(a =>a>8).ToArray();  
          foreach (var item in q)
          {
              Console.WriteLine(item);
              
          } 
        
         ///list by use linq
         List<string> name=new List<string>()
         {
             "ali",
             "AhmAd",
             "hassan",
             "rahim"
         };

         var qs=name.Where(a => a.ToLower().Contains("a")).ToList();
         foreach (var item in qs)
         {
              Console.WriteLine(item);
         }
        
         
         
          
            

        }
    }
}
