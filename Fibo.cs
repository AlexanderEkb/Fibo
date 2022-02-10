using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Fibo

{
  class Fibo : ITask
  {
    public string Run(string[] data)
    {
      int N = Convert.ToInt32(data[0]);
      // long answer = FindRecursive(N);
      BigInteger answer = FindIterative(N);
      return answer.ToString();
    }
    public long FindRecursive(long N)
    {
      long result = 0;
      if(N == 0)
        result = 0;
      else if((N == 1) || (N == 2))
        result = 1;
      else
        result = FindRecursive(N - 1) + FindRecursive(N - 2);
      
      return result;
    }

    public static BigInteger FindIterative(long N)
    {
      BigInteger result = 0;
      if(N == 0)
        result = 0;
      else if((N == 1) || (N == 2))
        result = 1;
      else
      {
        BigInteger F1 = 1;
        BigInteger F2 = 1;
        BigInteger FN = 0;

        for(long i=2; i<N; i++)
        {
          FN = F1+F2;
          F1 = F2;
          F2 = FN;
        }
        
        result = FN;
      }
      
      return result;
    }
  }
}
