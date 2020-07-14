# Logging Implementation #

This is an example of a ready-made logging service built on the abstract interfaces.
A driver or application author could decide to use this, instead of the default implementation provided by ASCOM.
Using this implementation implies that we are taking a dependency on NLog.
Hence `NLog` in the name. This would be packaged in its own separate NuGet package.
