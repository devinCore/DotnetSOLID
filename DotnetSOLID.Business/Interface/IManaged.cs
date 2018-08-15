using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetSOLID.Business
{
    public interface IManaged
    {
        IEmployee Manager { get; set; }

        void AssignManager(IEmployee manager);
    }
}
