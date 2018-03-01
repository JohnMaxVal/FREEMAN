﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Ninject;

namespace SportsStore.WebUI.Infrastructure
{
    public class NinjectDependencyResolver : IDependencyResolver
    {
        private IKernel kernel;

        public NinjectDependencyResolver(IKernel kernelParam)
        {
            kernel = kernelParam;
            AddBindings();
        }

        public object GetService(Type serviceType)
        {
            return kernel.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serverType)
        {
            return kernel.GetAll(serverType);
        }

        private void AddBindings()
        {

        }
    }
}