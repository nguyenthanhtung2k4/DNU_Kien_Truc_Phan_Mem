using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankApp.Events;

namespace BankApp
{
    public class EventBus
    {
        private readonly Dictionary<Type, List<Action<IEvent>>> _handlers = new();
        public void Subscribe<T>(Action<T> handler) where T : IEvent
        {
            var type = typeof(T)
                if (!_handlers.ContainsKey(type))
            {
                _handlers[type] = new List<Action<IEvent>>();
                _handlers[Type].Add(e => handler((T)e));

            }
           
        }
    }
}
