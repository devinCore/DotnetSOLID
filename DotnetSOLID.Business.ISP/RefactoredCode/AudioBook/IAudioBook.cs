using System;

namespace DotnetSOLID.Business.ISP.RefactoredCode.Interface
{
    public interface IAudioBook : ILibraryItem
    {
        int RuntimeInMinutes { get; set; }
    }
}