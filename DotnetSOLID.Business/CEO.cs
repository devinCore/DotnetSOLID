using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetSOLID.Business
{
    public class CEO : BaseEmployee, IManager
    {
        public override void CalculatePerHourRate(int rank)
        {
            base.CalculatePerHourRate(rank);
        }

        public void GeneratePerformanceReview()
        {
            Console.WriteLine("Doing a performance Review for underlings");
        }
    }
}
