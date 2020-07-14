# Application/Driver Example #

This is an example of an application that needs a logging service.

It uses the service interfaces and chooses to use the NLog-based implementation.

I have chosen to use dependency injection with Ninject, just because its what I'm most familiar with.
The Ninject Kernel is defined in `CompositionRoot.cs`.

Any other dependency injection utility could be used just as easily, or indeed the logger could just be stored in a global property, for a "quick and dirty" approach.

Note that the application owns the `NLog.config` file.
This controls the logging targets, rules and filters, and layout,
all of which can be changed in XML without editing the code,
even while the code is running. Nice.
This means that library writers do not have to be concerned about formatting.
So the exact some library might produce very different log output,
depending on which application is using it.
