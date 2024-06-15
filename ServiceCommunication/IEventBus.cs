using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceCommunication
{
    public interface IEventBus
    {
        void Publish(string message);
         void Subscribe();
    }
}