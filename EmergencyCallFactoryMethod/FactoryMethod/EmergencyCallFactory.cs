using System;
using System.Collections.Generic;
using System.Text;

namespace EmergencyCallFactoryMethod.FactoryMethod
{
    //Abstract Creator
    public abstract class EmergencyCallFactory
    {
        //Factory Method
        public abstract EmergencyCall CreateCall(Guid idCall);

        public static EmergencyCallFactory EmergencyCall(TypeCall typeCall)
        {
            if (typeCall == TypeCall.Fire)
                return new EmergencyFireFactory();
            if (typeCall == TypeCall.CarAccident)
                return new EmergencyCarAccidentFactory();

            throw new ApplicationException("unrecognized call type");
        }
    }
}
