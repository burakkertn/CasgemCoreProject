using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using Pizzapan.PresentationLayer.Models;


namespace Pizzapan.PresentationLayer.Controllers
{
    public class SendMailController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(MailRequest p)
        {
            MimeMessage mimeMessage = new MimeMessage();

            MailboxAddress mailboxAddress = new MailboxAddress("Admin", "dostdigro@gmail.com");
            mimeMessage.From.Add(mailboxAddress);
            mimeMessage.To.Add(mailboxAddress);


            MailboxAddress mailboxAddressTo = new MailboxAddress("User", p.ReceiverMail);

            mimeMessage.To.Add(mailboxAddressTo);


            var bodyBuilder = new BodyBuilder();



            p.TextBody = bodyBuilder.ToMessageBody();

            mimeMessage.Body = bodyBuilder.ToMessageBody();

            mimeMessage.Subject = p.Subject;


            SmtpClient smtpClient = new SmtpClient();

            smtpClient.Connect("smtp.gmail.com", 587, false);
            smtpClient.Authenticate("dostdigro@gmail.com", "tlzmlssykfxsflrv");
            smtpClient.Send(mimeMessage);
            smtpClient.Disconnect(true);

            return View();
        }
    }
}

