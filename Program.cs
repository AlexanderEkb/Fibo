using System;

namespace Fibo
{
    class Program
    {
        static void Main(string[] args)
        {
          ITask fibo = new Fibo();
          Tester tester = new Tester(fibo, @".\tests\");
          tester.RunAllTests();
          // tester.RunTest(1);
        }
    }
}
