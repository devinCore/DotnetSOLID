using System;

namespace DotnetSOLID.Business.ISP
{
    public interface ILibraryItem
    {
        string LibraryId { get; set; }
        string Title { get; set; }

        // Moved to IBook
        //string Author { get; set; }
        //int Pages { get; set; }

        // Moved to IBorrowable
        //DateTime BorrowDate { get; set; }
        //string Borrower { get; set; }
        //int CheckOutDurationInDays { get; set; }

        //void CheckIn();
        //void CheckOut(string borrower);
        //DateTime GetDueDate();
    }
}