using EventBus;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Service1.EventBus1
{
    public class Service1EventHandler : IIntegrationEventHandler<Service1Event>
    {
        private readonly ILogger<IIntegrationEventHandler> _logger;
        public Service1EventHandler(ILogger<IIntegrationEventHandler> logger)
        {
            _logger = logger;
        }

        public Task Handle(Service1Event @event)
        {
            _logger.LogInformation(@event.ServiceName, @event.Id, @event.CreateTime);
            return Task.CompletedTask;
        }
    }
}
