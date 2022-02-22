using Foodie360.Models;

namespace Foodie360.Services
{
  public interface IMailService
  {
    public Task SendEmailAsync(MailRequest mailrequest);
  }
}