using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp.Events
{
    record class AccountWithdrewEvent(string Id, decimal Amount) : IEvent;
}
