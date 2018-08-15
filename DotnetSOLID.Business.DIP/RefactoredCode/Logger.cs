using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetSOLID.Business.DIP.RefactoredCode
{
    public class Logger : ILogger
    {
        public void Log(string logInput)
        {
            Console.WriteLine(logInput);
        }
    }
}
