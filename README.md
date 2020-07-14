# TA.LoggingService.Sample #

A proof of concept and sample implementation of a logging service

The three projects in this solution demonstrate one possible way of defining and implementing a logging service,
such that users of the service don't necessarily need to take a dependency on any log provider.

This particular approach uses the _Builder Pattern_ which gives a fluent interface to the logging service.
This has been modeled closely on the `NLog.Fluent` namespace and works rather well in practice.
The result is a pair of pretty minimal interfaces that leave the implementation details wide open,
so it is fairly easy to build adapters for various logging engines.
The example implementation here builds an NLog adapter.

In the context of, say, the ASCOM Platform, then the service interfaces would go in the platform itself (`Ascom.Utilities.Logging`).

The `TA.LoggingService.NLog` project shows how a ready-made implementation can be made and shipped in its own NuGet package.
This one is an NLog adapter.

The `TA.ApplicationExample.Console` project shows how the end user would actually consume the service and NLog adapter
and uses dependency injection with _Ninject_.

Please see the `ReadMe.md` file within each project for more information.

![Dependencies Chart](assets\DependenciesGraph.png)
