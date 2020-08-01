// using SendGrid's C# Library
// https://github.com/sendgrid/sendgrid-csharp
using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Threading.Tasks;

namespace TestExec
{
    internal class TestSendGrid
    {
        public static async Task Execute()
        {
            var apiKey = Environment.GetEnvironmentVariable("dev101", EnvironmentVariableTarget.User);
            var client = new SendGridClient(apiKey);
            var from = new EmailAddress("test@myLocalEnv.com", "Example User");
            var subject = "Sending with SendGrid is Fun";
            var to = new EmailAddress("gnairooze@gmail.com", "George Nairooze");
            var plainTextContent = "and easy to do anywhere, even with C#";
            var htmlContent = "<strong>and easy to do anywhere, even with C#</strong>";
            var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);
            var response = await client.SendEmailAsync(msg);
        }
    }
}