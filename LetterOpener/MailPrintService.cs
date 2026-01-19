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
            return mailItems
                .Where(m => m.ShouldPrint)
                .OrderBy(m => m.Sender)
                .ThenBy(m => m.ReceivedDate)
                .GroupBy(m => m.Sender);
        }
    }
}
