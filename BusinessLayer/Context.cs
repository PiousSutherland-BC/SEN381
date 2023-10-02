using System;

public class Context
{
	private IStrategy myStrategy;
	public void setStrategy(IStrategy strategy) 
	{

	}
	public IStrategy GetStrategy()
	{
		return myStrategy;
	}

	public void monitorPerformance()
	{
		myStrategy.monitorPerformance();
	}
	public void escalate()
	{
		myStrategy.escalate();
	}
		
}
