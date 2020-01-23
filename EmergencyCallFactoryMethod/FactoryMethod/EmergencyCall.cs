using System;
using System.Collections.Generic;
using System.Text;

namespace EmergencyCallFactoryMethod.FactoryMethod
{
    public abstract class EmergencyCall
    {
        protected EmergencyCall(Guid idCall)
        {
            IdCall = idCall;
        }

        public Guid IdCall { get; set; }
        public abstract Call OpenCall();
    }
}
