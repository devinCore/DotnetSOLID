using DotnetSOLID.Business;
using DotnetSOLID.Business.DIP.RefactoredCode;
using DotnetSOLID.Business.ISP.OriginalCode;
using System;

namespace DotnetSOLID.ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            TestDIP();
            //Console.ReadLine();
        }

        public static void TestLSP()
        {
            var accountingVP = new Manager
            {
                FirstName = "Emma",
                LastName = "Stone"
            };

            accountingVP.CalculatePerHourRate(4);


            Employee emp = new Employee
            {
                FirstName = "Tim",
                LastName = "Corey"
            };


            emp.AssignManager(accountingVP);
            emp.CalculatePerHourRate(2);

            Console.WriteLine($"{emp.FirstName}'s salary is ${emp.Salary}/hour");
        }

        public static void TestISP()
        {

            var dvd = new DVD();
        }

        public static void TestDIP()
        {
            IPerson owner = Factory.CreatePerson();
            owner.FirstName = "Tim";
            owner.LastName = "Corey";
            owner.Email = "tim@iamtimcorey.com";
            owner.PhoneNumber = "555-1212";

            IChore chore = Factory.CreateChore();
            chore.ChoreName = "Take out the trash";
            chore.Owner = owner;
            
            chore.PerformedWork(3);
            chore.PerformedWork(1.5);

            chore.CompleteChore();

            Console.ReadLine();
        }
    }
}
