using System;
using System.Collections.Generic;
using System.Text;

namespace EmergencyCallFactoryMethod.FactoryMethod
{
    //Concrete Creator
    public class EmergencyFireFactory : EmergencyCallFactory
    {
        //Factory Method
        public override EmergencyCall CreateCall(Guid idCall)
        {
            return new EmergencyFire(idCall);
        }
    }
}
