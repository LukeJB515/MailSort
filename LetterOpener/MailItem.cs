using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetterOpener
{
    public class MailItem
    {
        public MailPriority Priority { get; }
        //public bool ShouldPrint => 
    }

    public enum MailRepository
    {
        Low,
        Normal,
        High
    }
}
