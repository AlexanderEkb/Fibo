using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibo

{
  interface ITask
  {
    string Run(string[] data);
  }
}