using Castle.MicroKernel.Registration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WisdoreExample.Models;

namespace WisdoreExample.Installers
{
    public class ServiceInstaller : IWindsorInstaller
    {
        public void Install(Castle.Windsor.IWindsorContainer container, Castle.MicroKernel.SubSystems.Configuration.IConfigurationStore store)
        {
            container.Register(
            Component
                .For<ToDoListService>()
                .ImplementedBy<ToDoListServiceImpl>()
                .LifestyleTransient());
        }
    }
}