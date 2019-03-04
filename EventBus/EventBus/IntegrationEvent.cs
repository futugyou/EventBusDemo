using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EventBus
{
    public class IntegrationEvent
    {
        [JsonProperty]
        public Guid Id { get; private set; }
        [JsonProperty]
        public DateTime CreateTime { get; private set; }
        public IntegrationEvent()
        {
            Id = Guid.NewGuid();
            CreateTime = DateTime.Now;
        }
        [JsonConstructor]
        public IntegrationEvent(Guid id, DateTime dateTime)
        {
            Id = id;
            CreateTime = dateTime;
        }
    }
}
