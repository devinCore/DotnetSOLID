namespace DotnetSOLID.Business.DIP.RefactoredCode
{
    public interface IMessageSender
    {
        void SendEmail(IPerson owner, string message);
    }
}