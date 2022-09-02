namespace SendEmail.Services
{
    public interface IMaillingServices
    {
        Task SendEmailAsync(string mailTo, string subject, string body, IList<IFormFile> attachment = null);
    }
}
