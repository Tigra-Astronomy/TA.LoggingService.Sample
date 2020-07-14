# Logging Service Definition #

This is the library that defines the logging service interfaces.
In the case of ASCOM, this would be part of the platform, perhaps in `Ascom.Utilities.Logging`.

No code is defined here, only the two interfaces `ILog` and `IFluentLogBuilder`.
Therefore we have no external dependencies.
Drivers and applications can choose either:

- To implement the interfaces themselves
- To use a ready-made implementation packaged in a separate nuget package

There is no dependency on any logging utility, there are just 2 interfaces.
It's completely up to the driver or application developer to decide if they want to take a dependency on a logging platform (such as NLog).

ASCOM might choose to provide a default implementation based on the existing logger.

In designing the interfaces, I have taken into account the following factors:

- I am rather fond of NLog's fluent interface and didn't want to lose that.
  The two interfaces follow the _Builder Pattern_ and are very easy to use in practice (try it!).
  It is much easier to 'dot' into the builder methods than it is to enter a bunch or arguments.
- I wanted to not do anything to prevent the use of semantic logging (which NLog supports in a way that is almost invisible to the user).
- I wanted to keep the interfaces simple but easy to use. 
  For me, NLog's gigantic `ILogger` interface was out of the question because it is
  a "header interface" and breaks the _Interface Segregation Principle_.
- This is a strong design that follows best practices:
  - Dependency Inversion Principle (for unit testing, dependency injection and loose coupling)
  - Single Responsibility Principle
  - Interface Segregation Principle