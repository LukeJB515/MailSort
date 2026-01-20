using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetterOpener
{
    public class MailPrintService
    {
        public IEnumerable<IGrouping<string, MailItem>> BuildPrintQueue(
            IEnumerable<MailItem> mailItems)
        {
            var printableMail = mailItems.Where(IsPrintable);

            return SortMail(printableMail)
                .GroupBy(m => m.Sender);

            //return mailItems
            //    .Where(m => m.ShouldPrint)
            //    .OrderBy(m => m.Sender)
            //    .ThenBy(m => m.ReceivedDate)
            //    .GroupBy(m => m.Sender); //optional method, leaving commented out for now in case this is preferred
        }

        private static bool IsPrintable(MailItem mail)
        {
            return mail.IsInvoice || mail.Priority == MailPriority.High;
        }

        private static IOrderedEnumerable<MailItem> SortMail(
            IEnumerable<MailItem> mailItems)
        {
            return mailItems
                .OrderBy(m => m.Sender)
                .ThenBy(m => m.ReceivedDate);
        }
    }
}
