using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamPlayer.App
{
    public static class ServiceLocator
    {
        private static readonly Dictionary<Type, Type> services = new Dictionary<Type, Type>();

        public static void RegisterService<T>(Type service)
        {
            services[typeof(T)] = service;
        }

        public static T Resolve<T>()
        {
            return (T) Activator.CreateInstance(services[typeof(T)]);
        }
    }
}
