using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EventBus
{
    public interface IEventBus
    {
        void Punlish(IntegrationEvent @event);
        void Subscribe<T, H>() where T : IntegrationEvent where H : IIntegrationEventHandler<T>;
        void Unsubscirbe<T, H>() where T : IntegrationEvent where H : IIntegrationEventHandler<T>;
    }
}
