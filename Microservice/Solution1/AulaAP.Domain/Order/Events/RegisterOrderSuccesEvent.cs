using AulaAp.Domain.Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace AulaAP.Domain.Events
{
    public class RegisterOrderSuccesEvent : Event
    {
        public RegisterOrderSuccesEvent(string orderCode)
        {
            OrderCode = orderCode;
        }

        public string OrderCode { get; set; }
    }
}
