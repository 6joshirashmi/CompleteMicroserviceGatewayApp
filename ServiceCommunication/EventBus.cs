using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;


namespace ServiceCommunication
{
    public class EventBus:IEventBus
    {
        public void Publish(string message)
         {// host in docker other wise we right localhost in hostname
var factory = new ConnectionFactory{
                    HostName = "host.docker.internal",
                    UserName = "guest",
                    Password = "guest",
                    Port = 5672
                };

  //chenal
  // CreateModelto create a new chenal return to chenal obj now creating the que within the same chenal by qdeclare
  // default time out is 15 minute

  using(var connection = factory.CreateConnection()){
                using(var channel = connection.CreateModel()){
                    channel.QueueDeclare("myQueue",false,false,false,null);
                    var byteMess = Encoding.UTF8.GetBytes(message);
                    channel.BasicPublish("","myQueue",body:byteMess);
                    Console.WriteLine("Message Published{0}",message);
                }
            }
         }
    public  void Subscribe()
    {


     }

    }
}