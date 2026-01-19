using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetterOpener
{
    public class MailRepository
    {
        public IEnumerable<MailItem> GetItem()
        {
            return new List<MailItem>
            {
                new MailItem
                {

                },
                new MailItem
                {

                },
                new MailItem
                {

                }
            };
        }
    }
}
