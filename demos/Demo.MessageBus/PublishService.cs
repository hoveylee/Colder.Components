﻿using Colder.MessageBus.Abstractions;
using Demo.Common;
using Microsoft.Extensions.Hosting;
using System.Threading;
using System.Threading.Tasks;

namespace Demo.MessageBus
{
    class PublishService : BackgroundService
    {
        private readonly IMessageBus _messageBus;
        public PublishService(IMessageBus messageBus)
        {
            _messageBus = messageBus;
        }
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            await _messageBus.Publish(new RequestMessage
            {
                Text = "小明"
            });
        }
    }
}
