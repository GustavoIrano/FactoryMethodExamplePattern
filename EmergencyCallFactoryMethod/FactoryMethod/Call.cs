using System;
using System.Collections.Generic;
using System.Text;

namespace EmergencyCallFactoryMethod
{
    public class Call
    {
        public Guid IdCall { get; set; }
        public bool Opened { get; set; }

        public Call(Guid idCall)
        {
            IdCall = idCall;
        }

        public void InitiateCall(string descriptionCall)
        {
            Console.WriteLine("Rescue to call: " + descriptionCall);
        }

        public void OpenCall()
        {
            Opened = true;
            Console.WriteLine("Call open");
        }

        public void CloseCall()
        {
            Opened = false;
            Console.WriteLine("Call close");
        }
    }
}
