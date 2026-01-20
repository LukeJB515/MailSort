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
            int totalPrinted = 0;

            Console.WriteLine("Pre-Print Mail Filter Summary");
            Console.WriteLine(new string('-', 32));
            Console.WriteLine();

            foreach (var group in groupedMail)
            {
                Console.WriteLine($"Sender: {group.Key}");

                foreach (var mail in group)
                {
                    Console.WriteLine($"  {mail.ReceivedDate:d} | {mail.Subject}");
                    totalPrinted++;
                }

                Console.WriteLine();
            }

            Console.WriteLine($"Total items approved for printing: {totalPrinted}");
        }
    }
}
