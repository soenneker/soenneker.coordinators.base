using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Soenneker.Coordinators.Base.Abstract;

namespace Soenneker.Coordinators.Base;

/// <inheritdoc cref="IBaseCoordinator"/>
public abstract class BaseCoordinator : IBaseCoordinator
{
    /// <summary>
    /// Gets the logger supplied for the coordinator.
    /// </summary>
    protected ILogger<BaseCoordinator> Logger { get; }

    /// <summary>
    /// Gets the application's composed configuration.
    /// </summary>
    protected IConfiguration Config { get; }

    protected BaseCoordinator(IConfiguration config, ILogger<BaseCoordinator> logger)
    {
        Config = config;
        Logger = logger;
    }
}
