using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetterOpener
{
    public class MailItem
    {
        public string Sender { get; }
        public string Subject { get;  }
        public DateTime ReceivedDate { get; }
        public bool IsInvoice { get; }
        public MailPriority Priority { get; }

        public bool ShouldPrint => IsInvoice || Priority == MailPriority.High;
    }

    public enum MailPriority
    {
        Low,
        Normal,
        High
    }
}
