using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetSOLID.Business.DIP.RefactoredCode
{
    public class Texter : IMessageSender
    {
        public void SendEmail(IPerson owner, string message)
        {
            Console.WriteLine($"I am texting {owner.FirstName} to say that {message}");
        }
    }
}
