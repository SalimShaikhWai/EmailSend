// See https://aka.ms/new-console-template for more information
using System.Net;
using System.Net.Mail;

Console.WriteLine("Hello, World!");
var client = new SmtpClient("smtp.mailtrap.io", 2525)
{
    Credentials = new NetworkCredential("baa610e4dac39d", "7ed570d90d8dc7"),
    EnableSsl = true
};
client.Send("salim.shaikh@waiin.com", "adil.sayyad@waiin.com", "Hello world", "hello adil test ");
Console.WriteLine("Sent");
Console.ReadLine();