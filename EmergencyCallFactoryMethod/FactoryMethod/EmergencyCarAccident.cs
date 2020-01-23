using System;
using System.Collections.Generic;
using System.Text;

namespace EmergencyCallFactoryMethod.FactoryMethod
{
    public class EmergencyCarAccident : EmergencyCall
    {
        public EmergencyCarAccident(Guid idCall) : base(idCall)
        {
            IdCall = idCall;
        }

        public override Call OpenCall()
        {
            Console.WriteLine("Initiating call...");
            var call = new Call(IdCall);
            call.OpenCall();

            return call;
        }
    }
}
