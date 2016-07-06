using System;
using System.Net.Mail;

namespace Automailer
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                String Date = DateTime.Today.ToString("dd.MM");
                string Content = "Der Artikel-Bericht für den " + Date + " wurde erfolgreich erstellt und befindet sich im Anhang.";
            }
            
            catch (Exception e)
            {
                
            }
        }
    }
}
