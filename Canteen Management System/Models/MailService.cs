using Microsoft.Build.Framework;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Canteen_Management_System.Models;
using MailKit.Net.Smtp;
using MimeKit;
using MailKit.Security;
using System;
using System.IO;
using System.Collections.Generic;



namespace Canteen_Management_System.Models
{
    public class MailService
    {
        private readonly MailSettings _mailSettings;
        public MailService(MailSettings mailSettings)
        {
            _mailSettings = mailSettings;
        }
        public async Task SendMailAsync(MailRequest mailRequest)
        {
            var email = new MimeMessage();
            email.Sender = MailboxAddress.Parse(_mailSettings.Email);
            email.To.Add(MailboxAddress.Parse(mailRequest.ToEmail));
            email.Subject = mailRequest.Subject;
            using (SmtpClient client = new SmtpClient())
            {
               /* client.ServerCertificateValidationCallback = (s, c, h, e) => true;
                client.CheckCertificateRevocation = false;
                await client.ConnectAsync(_mailSettings.Host, _mailSettings.Port, false);
                await client.AuthenticateAsync(_mailSettings.Email, _mailSettings.Password);
                await client.SendAsync(email);
                client.Dispose(); */
            }
        }
    }
}