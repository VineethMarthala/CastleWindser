using System;
using WebActivatorEx;

[assembly: PreApplicationStartMethod(typeof(WisdoreExample.App_Start.WindsorActivator), "PreStart")]
[assembly: ApplicationShutdownMethodAttribute(typeof(WisdoreExample.App_Start.WindsorActivator), "Shutdown")]

namespace WisdoreExample.App_Start
{
    public static class WindsorActivator
    {
        static ContainerBootstrapper bootstrapper;

        public static void PreStart()
        {
            bootstrapper = ContainerBootstrapper.Bootstrap();
        }
        
        public static void Shutdown()
        {
            if (bootstrapper != null)
                bootstrapper.Dispose();
        }
    }
}