using System;
using System.Reflection;

namespace DeveloperSample.ClassRefactoring
{
    public enum SwallowType
    {
        African, European
    }

    public enum SwallowLoad
    {
        None, Coconut
    }

    public class SwallowFactory
    {
        public Swallow GetSwallow(SwallowType swallowType)
    	{ 
	    	return new Swallow(swallowType);
	    }
    }

    public class Swallow
    {
        public SwallowType Type { get; }
        public SwallowLoad Load { get; private set; }

        public Swallow(SwallowType swallowType)
        {
            Type = swallowType;
        }

        public void ApplyLoad(SwallowLoad load, Swallow swallowObj)
        {
	    	swallowObj.GetType().GetProperty("Load").SetValue(swallowObj, load, null);
        }

        public double GetAirspeedVelocity()
        {
        	if (Type == SwallowType.African)	
            {
                if (Load == SwallowLoad.None)
                {
                    return 22;
                }
                else if (Load == SwallowLoad.Coconut)
                {
                    return 18;
                }		
                else
                {
                    // invalid load value
                    throw new InvalidOperationException();
                }
            }
            else if (Type == SwallowType.European)
            {
                if (Load == SwallowLoad.None)
                {
                    return 20;
                }
                else if (Load == SwallowLoad.Coconut)
                {
                    return 16;
                }		
                else
                {
                    // invalid load value
                    throw new InvalidOperationException();
                }
            }
            else
            {
                // invalid bird
                throw new InvalidOperationException();
            } 
        }
    }
}
