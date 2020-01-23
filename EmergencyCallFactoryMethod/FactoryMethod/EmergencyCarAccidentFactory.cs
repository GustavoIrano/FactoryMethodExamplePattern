using System;
using System.Collections.Generic;
using System.Text;

namespace EmergencyCallFactoryMethod.FactoryMethod
{
    //Concrete Creator
    public class EmergencyCarAccidentFactory : EmergencyCallFactory
    {
        //Factory Method
        public override EmergencyCall CreateCall(Guid idCall)
        {
            return new EmergencyCarAccident(idCall);
        }
    }
}
