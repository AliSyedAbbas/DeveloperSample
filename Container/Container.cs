using System;
using System.Collections.Generic;

namespace DeveloperSample.Container
{
    public class Container
    {
	private Dictionary<Type, Type> dictImplementation = new Dictionary<Type, Type>();

        public void Bind(Type type1, Type type2)
        {
            dictImplementation.Add(type1, type2);
        }

        public T Get<T>()
        {
            if (dictImplementation.TryGetValue(typeof(T), out Type type))
            {
                var obj = Activator.CreateInstance(type);
                return (T)obj;
            }
            return default(T);
        }
    }
}
