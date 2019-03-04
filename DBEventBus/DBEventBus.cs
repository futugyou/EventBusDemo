using EventBus;
using System;
using System.Collections.Generic;
using System.Text;

namespace DBEventBus
{
    public class DBEventBus : IEventBus
    {
        private readonly IEventBusSubscriptionsManager _manager;
        public DBEventBus(IEventBusSubscriptionsManager manager)
        {
            _manager = manager;
        }
        public void Punlish(IntegrationEvent @event)
        {
            //_manager.
        }

        public void Subscribe<T, H>()
            where T : IntegrationEvent
            where H : IIntegrationEventHandler<T>
        {
            throw new NotImplementedException();
        }

        public void Unsubscirbe<T, H>()
            where T : IntegrationEvent
            where H : IIntegrationEventHandler<T>
        {
            throw new NotImplementedException();
        }
    }
}
