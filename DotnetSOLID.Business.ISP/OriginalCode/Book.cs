using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetSOLID.Business.ISP.OriginalCode
{
    public class Book : ILibraryItem
    {
        public string Author { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime BorrowDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Borrower { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int CheckOutDurationInDays { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string LibraryId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Pages { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Title { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void CheckIn()
        {
            throw new NotImplementedException();
        }

        public void CheckOut(string borrower)
        {
            throw new NotImplementedException();
        }

        public DateTime GetDueDate()
        {
            throw new NotImplementedException();
        }
    }
}
