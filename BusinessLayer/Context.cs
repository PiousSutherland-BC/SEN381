using System;

public class Context
{
	private IStrategy myStrategy;
	class Context
	{
		public void setStrategy(IStrategy strategy) 
		{
			//setter code
		}
		public IStrategy GetStrategy()
		{
			//getter code
			return myStrategy;
		}
        //The Context delegates some work to the Strategy object instead of
        // implementing multiple versions of the algorithm on its own.
        public void monitorPerformance()
		{
			myStrategy.monitorPerformance();
		}
		public void escalate()
		{
			myStrategy.escalate();
		}
	}
		
}
