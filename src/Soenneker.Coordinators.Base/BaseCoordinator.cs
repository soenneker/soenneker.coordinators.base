using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Soenneker.Coordinators.Base.Abstract;

namespace Soenneker.Coordinators.Base;

///<inheritdoc cref="IBaseCoordinator"/>
public abstract class BaseCoordinator : IBaseCoordinator
{
    protected ILogger<BaseCoordinator> Logger { get; }

    protected IConfiguration Config { get; }

    protected BaseCoordinator(IConfiguration config, ILogger<BaseCoordinator> logger)
    {
        Config = config;
        Logger = logger;
    }
}