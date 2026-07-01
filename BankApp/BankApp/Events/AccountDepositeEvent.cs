using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp.Events
{
    public record class AccountDepositedEvent(string Id, decimal Amount) : IEvent;

}