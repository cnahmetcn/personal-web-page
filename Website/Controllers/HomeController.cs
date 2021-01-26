using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using Website.Models;

namespace Website.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Contact(Mail m)
        {
            try
            {
                SmtpClient client = new SmtpClient("smtp.gmail.com",587);
                client.Credentials = new NetworkCredential("cnahmetcn@gmail.com", "mewglrmmmloobtfe");
                client.EnableSsl = true;

                MailMessage msj = new MailMessage();
                msj.From = new MailAddress(m.Email, m.Name+" "+m.Surname);
                msj.To.Add("cnahmetcn@gmail.com");
                msj.Subject = m.Subject;
                msj.Body = m.Message;

                client.Send(msj);

                MailMessage msj1 = new MailMessage();
                msj1.From = new MailAddress("cnahmetcn@gmail.com","Ahmet Can");
                msj1.To.Add(m.Email);
                msj1.Subject = "Teşekkürler";
                msj1.Body = "Benimle iletişime geçtiğiniz için teşekkür ederim";

                client.Send(msj1);

                ViewBag.Success = "Mailiniz alınmıştır. Teşekkür ederim";
                return View();
            }
            catch (Exception)
            {
                ViewBag.Error = "Mailiniz gönderilemedi. Lütfen tekrar deneyin";
                return View();
            }
        }
    }
}
