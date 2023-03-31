using Microsoft.Extensions.Logging;
using Soenneker.Coordinators.Base.Abstract;
using Soenneker.Utils.Cancellation.Abstract;

namespace Soenneker.Coordinators.Base;

///<inheritdoc cref="IBaseCoordinator"/>
public abstract class BaseCoordinator : IBaseCoordinator
{
    protected ILogger<BaseCoordinator> Logger { get; }

    protected ICancellationUtil CancellationUtil { get; }

    protected BaseCoordinator(ILogger<BaseCoordinator> logger, ICancellationUtil cancellationUtil)
    {
        Logger = logger;
        CancellationUtil = cancellationUtil;
    }
}