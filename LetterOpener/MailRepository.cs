using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetterOpener
{
    public class MailRepository
    {
        public IEnumerable<MailItem> GetMail()
        {
            return new List<MailItem>
            {
                new MailItem
                {
                    //Sender = "",
                    //Subject = "",
                    //ReceivedDate = DateTime.Today.AddDays(-1),
                    //IsInvoice = false,
                    //Priority = MailPriority.Normal
                },
                new MailItem
                {
                    //Sender = "",
                    //Subject = "",
                    //ReceivedDate = DateTime.Today.AddDays(-1),
                    //IsInvoice = false,
                    //Priority = MailPriority.Normal
                },
                new MailItem
                {
                    //Sender = "",
                    //Subject = "",
                    //ReceivedDate = DateTime.Today.AddDays(-1),
                    //IsInvoice = false,
                    //Priority = MailPriority.Normal
                }
            };
        }
    }
}
