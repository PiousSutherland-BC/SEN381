using System;

public class ContractMaintenance  implements IStrategy
{
    public ContractMaintenance() 
    {
        @Override public void monitorPerformance()
        {
            myStrategy.monitorPerformance();
        }
        @Override public void escalate()
        {
            myStrategy.escalate();
        }
        string Agreementviewing(string Client)
        {

            return Client;
        }
        void createContractPackage()
        {
            // Define contract types as packages of services and service level agreements
        }

        void viewContractAvailability()
        {
            // Manage availability of contract types
        }

        void viewContractPerformance()
        {
            // View performance of contract types
        }

    }
}
