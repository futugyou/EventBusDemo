using System;
using System.Collections.Generic;
using System.Text;

namespace EventBus
{
    /// <summary>
    ///  因为是inmemory，所以能用地方有限
    /// </summary>
    public class InMemoryEventBus : IEventBus
    {
        private readonly IEventBusSubscriptionsManager _manager;
        private readonly IServiceProvider _provider;
        public InMemoryEventBus(IEventBusSubscriptionsManager manager,
            IServiceProvider provider)
        {
            _provider = provider;
            _manager = manager;
        }
        public void Punlish(IntegrationEvent @event)
        {
            var eventType = @event.GetType();
            var handlers = _manager.GetHandlersForEvent(eventType.Name);
            //var handlers = _manager.GetHandlersForEvent<IntegrationEvent>();
            foreach (var handlerInfo in handlers)
            {
                var handler = _provider.GetService(handlerInfo.HandlerType);
                var method = handlerInfo.HandlerType.GetMethod("Handle");
                method.Invoke(handler, new object[] { @event });
            }
        }

        public void Subscribe<T, H>()
            where T : IntegrationEvent
            where H : IIntegrationEventHandler<T>
        {
            _manager.AddSubscription<T, H>();
        }

        public void Unsubscirbe<T, H>()
            where T : IntegrationEvent
            where H : IIntegrationEventHandler<T>
        {
            _manager.RemoveSubscription<T, H>();
        }
    }
}
