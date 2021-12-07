using System;
using System.Linq;
using System.Collections.Generic;
using System.Globalization;

namespace sample1
{
    class Program
    {
        delegate void mydelegate(int x,int y);
        static void Main(string[] args)
        {
             mydelegate myd=new mydelegate(sum);
             
            
               myd=myd+men+div;

               myd(5,6);
              

        }

        public static void sum(int a, int b)
        {
            System.Console.WriteLine((a+b));
        }

         public static void men(int a, int b)
        {
            System.Console.WriteLine((a-b));
        }

         public static void div(int a, int b)
        {
            System.Console.WriteLine((a/b));
        }



    }

  }
