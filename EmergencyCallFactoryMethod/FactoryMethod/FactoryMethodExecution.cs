using System;
using System.Collections.Generic;
using System.Text;

namespace EmergencyCallFactoryMethod.FactoryMethod
{
    public class FactoryMethodExecution
    {
        public static void Execute()
        {
            var callFire = EmergencyCallFactory.EmergencyCall(TypeCall.Fire)
                .CreateCall(new Guid())
                .OpenCall();

            callFire.InitiateCall("Fire in the forest");
            callFire.CloseCall();

            Console.WriteLine("");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("");

            var callCarAccident = EmergencyCallFactory.EmergencyCall(TypeCall.CarAccident)
                .CreateCall(new Guid())
                .OpenCall();

            callCarAccident.InitiateCall("Car accident in the road");
            callCarAccident.CloseCall();
        }
    }
}
