using EventBus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Service1.EventBus1
{
    public class Service1Event : IntegrationEvent
    {
        public string ServiceName { get; set; }
    }
}
