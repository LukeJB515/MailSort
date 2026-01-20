using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetterOpener
{
    class Program
    {
        static void Main()
        {
            var repository = new MailRepository();
            var printService = new MailPrintService();
            var printer = new ConsolePrinter();

            var mailItems = repository.GetMail();
            var printQueue = printService.BuildPrintQueue(mailItems);

            printer.PrintSummary(printQueue);

            Console.WriteLine();
            Console.WriteLine("Processing complete. Press any key to exit.");
            Console.ReadKey();
        }
    }
}
