using System;

public class ServiceDepartment
{
	public ServiceDepartment()
	{
		static void answer()
		{
            //code to anser incoming service calls 
		}
        static void viewServiceProgress()
        {
            //Code to be able to view the progress of services offered to a client
        }
        static void recieveServiceRequest()
        {
            //Code to enable premier solutions to recieve service requests from clients
        }
        static string trackJob(string job)
        {
            //code to be able to track all jobs and see their current status
            return job;
        }
        static string ReassignJob(string job)
        {
            //Code to be able to reasign jobs
            return job;
        }
        static void closeServiceRequest(string serviceRequest)
        {
            //code to close a service request either due to completion or cancelation
        }
    }
}
