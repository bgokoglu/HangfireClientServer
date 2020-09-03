using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CommonLib
{
    public interface IEmailService
    {
        void SendWelcomeEmail(string message);
    }

    public class EmailService : IEmailService
    {
        public void SendWelcomeEmail(string message)
        {
            Console.WriteLine($"Sending welcome email: {message}...");

            Thread.Sleep(2000);

            Console.WriteLine("Sent welcome email...");
        }
    }
}
