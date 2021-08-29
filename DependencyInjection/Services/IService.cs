using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjection.Services
{
    // Don't Repeat Yourself ( DRY )
    public interface ServiceBase
    {
        string GuidId { get; }
    }

    public interface ITransientService : ServiceBase
    {
    }

    public interface IScopedService : ServiceBase
    {
    }

    public interface ISingletonService : ServiceBase
    {
    }
}
