[![](https://img.shields.io/nuget/v/Soenneker.Coordinators.Base.svg?style=for-the-badge)](https://www.nuget.org/packages/Soenneker.Coordinators.Base/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.coordinators.base/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.coordinators.base/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/Soenneker.Coordinators.Base.svg?style=for-the-badge)](https://www.nuget.org/packages/Soenneker.Coordinators.Base/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.coordinators.base/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.coordinators.base/actions/workflows/codeql.yml)

# Soenneker.Coordinators.Base

Provides a small base class for application coordinators, with protected access to `IConfiguration` and `ILogger`.

## Install

```bash
dotnet add package Soenneker.Coordinators.Base
```

## Usage

```csharp
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Soenneker.Coordinators.Base;

public sealed class OrdersCoordinator : BaseCoordinator
{
    public OrdersCoordinator(
        IConfiguration configuration,
        ILogger<OrdersCoordinator> logger)
        : base(configuration, logger)
    {
    }

    public void Coordinate()
    {
        Logger.LogInformation("Coordinating orders for {Environment}", Config["Environment"]);
    }
}
```

`IBaseCoordinator` is an empty marker interface. `BaseCoordinator` stores the configuration and logger references; it does not implement orchestration, cancellation, retries, validation, or dependency-injection registration.

The logger property is typed as `ILogger<BaseCoordinator>`, but `ILogger<T>` is covariant, so a derived coordinator's `ILogger<DerivedCoordinator>` can be passed to the base constructor while retaining the derived logging category.

Configuration is the application's composed `IConfiguration`. Derived coordinators should avoid logging secrets or returning raw configuration values to callers.
