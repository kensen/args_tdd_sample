using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Args_tdd_sample
{
    class Program
    {
        static void Main(string[] args)
        {
            

          Type type = Type.GetType("System.String[]");

         // Type type = typeof(string[]);

          var n = type.FullName;

              var q = Expression.Parameter(type, "l");

          var t=  Convert.ChangeType("false", q.Type);

            Console.WriteLine( t);
            Console.Read();
        }
    }
}
