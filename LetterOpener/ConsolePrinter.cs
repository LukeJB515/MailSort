using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetterOpener
{
    public class ConsolePrinter
    {
        public void PrintSummary(IEnumerable<IGrouping<string, MailItem>> groupedMail)
        {
            foreach (var group in groupedMail)
            {
                Console.WriteLine($"Sender: {group.Key}");

                foreach (var mail in group)
                {
                    Console.WriteLine($"  {mail.ReceivedDate:d} | {mail.Subject}");
                }

                Console.WriteLine();
            }
        }
    }
}
