namespace Dependency_Injection_ASP.NetCore.Services
{
   public interface IEmailSenderService
    {
        void SendEmail(string Email);
    }
    public class EmailSenderService : IEmailSenderService
    {
        public void SendEmail(string Email) 
            {
                //TODO
            }
    }
}
