using ModusPersonalSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;

namespace ModusPersonalSite.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(ContactInfo contact)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            string bodyText = string.Format(
                "Name:<strong>{0}</strong><br/>Email:{1}<br/>Message:{2}<br/>"
                , contact.Name
                , contact.Email
                , contact.Message

                );
            MailMessage msg = new MailMessage(
                "melissa@melissaogle.com",
                "melissaogle68@gmail.com",
                "New Conact" + contact.Name,
                bodyText
                );

            msg.Priority = MailPriority.High;
            msg.IsBodyHtml = true;

            msg.ReplyToList.Add(contact.Email);

            SmtpClient emailSender = new SmtpClient("mail.melissaogle.com");

            emailSender.Credentials = new System.Net.NetworkCredential(
                "melissa@melissaogle.com",
                "Lucky12#"
                );

            emailSender.Send(msg);


            return View("ContactConfirm", contact);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Contact(ContactInfo contact)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            string bodyText = string.Format(
                "Name:<strong>{0}</strong><br/>Email:{1}<br/>Message:{2}<br/>"
                , contact.Name
                , contact.Email
                , contact.Message

                );
            MailMessage msg = new MailMessage(
                "melissa@melissaogle.com",
                "melissaogle68@gmail.com",
                "New Conact" + contact.Name,
                bodyText
                );

            msg.Priority = MailPriority.High;
            msg.IsBodyHtml = true;

            msg.ReplyToList.Add(contact.Email);

            SmtpClient emailSender = new SmtpClient("mail.melissaogle.com");

            emailSender.Credentials = new System.Net.NetworkCredential(
                "melissa@melissaogle.com",
                "Lucky12#"
                );

            emailSender.Send(msg);


            return View("ContactConfirm", contact);
        }
    }
}