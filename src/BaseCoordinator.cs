﻿using Microsoft.Extensions.Logging;
using Soenneker.Coordinators.Base.Abstract;

namespace Soenneker.Coordinators.Base;

///<inheritdoc cref="IBaseCoordinator"/>
public abstract class BaseCoordinator : IBaseCoordinator
{
    protected ILogger<BaseCoordinator> Logger { get; }

    protected BaseCoordinator(ILogger<BaseCoordinator> logger)
    {
        Logger = logger;
    }
}