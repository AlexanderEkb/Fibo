using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibo

{
  class Fibo : ITask
  {
    public string Run(string[] data)
    {
      int N = Convert.ToInt32(data[0]);
      long answer = FindRecursive(N);
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
  }
}
