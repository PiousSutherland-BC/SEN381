using System;

public class ServiceDepartment implements IStrategy
{
	public ServiceDepartment()
	{
        @Override public void monitorPerformance()
        {
            //override code
        }
        @Override public void escalate()
        {
            //override code
    }
    public void answer()
		{
            //code to anser incoming service calls 
		}
        public void viewServiceProgress()
        {
            //Code to be able to view the progress of services offered to a client
        }
        public void recieveServiceRequest()
        {
            //Code to enable premier solutions to recieve service requests from clients
        }
        public string trackJob(string job)
        {
            //code to be able to track all jobs and see their current status
            return job;
        }
        public string ReassignJob(string job)
        {
            //Code to be able to reasign jobs
            return job;
        }
        public void closeServiceRequest(string serviceRequest)
        {
            //code to close a service request either due to completion or cancelation
        }
    }
}
