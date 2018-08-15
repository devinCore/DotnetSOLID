using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetSOLID.Business.DIP.RefactoredCode
{
    public class Emailer : IMessageSender
    {
        public void SendEmail(IPerson owner, string message)
        {
            Console.WriteLine($"Simulating email.. msg: Hi {owner.FirstName}, {message}");
        }
    }
}
