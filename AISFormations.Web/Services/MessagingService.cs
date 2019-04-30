using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using Microsoft.Azure.ServiceBus;
using Microsoft.Extensions.Configuration;

namespace AISFormations.Web.Services
{
    public class MessagingService : IMessagingService
    {
        private string _serviceBusConnectionString;
        private string _queueName;
        private static IQueueClient _queueClient;
        private IConfiguration _config;

        public MessagingService(IConfiguration config)
        {
            _config = config;
            _serviceBusConnectionString = _config["sbConnectionString"];
            _queueName = _config["queueName"];
            _queueClient = new QueueClient(_serviceBusConnectionString, _queueName);
        }


        public async Task PushMessage(FormationMessage message)
        {
            // send the message
            var msg = new Message(Encoding.UTF8.GetBytes(message.IdFormation.ToString()));
            await _queueClient.SendAsync(msg);
            
            // close connection to Service Bus Queue
            await _queueClient.CloseAsync();
        }
    }
}