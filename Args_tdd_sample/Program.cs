using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Args_tdd_sample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("参数解析：请输入一条命令");
            string cmdLine= Console.ReadLine();

            foreach (var item in cmdLine.Split("-"))
            {
                var p = item.Split(" ");
                var t = new Parser(cmdLine).GetParam(p[0]);
                Console.WriteLine($"{p[0]}:{t.Value}  ,type:{t.Value.GetType().FullName}");
            }

            Console.Read();
        }
    }
}
