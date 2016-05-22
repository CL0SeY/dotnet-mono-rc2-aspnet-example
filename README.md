# .NET Core 1.0 RC2 Example App (.NET 4.5.1 Framework using Docker + Mono)

How to:
```
> docker build -t dotnet-mono-rc2-aspnet-example .
> docker run -it -p 5000:5000 dotnet-mono-rc2-aspnet-example
```
And then browse to your docker host on port 5000.

## Issues

### LocalDB
LocalDB doesn't work on Linux. So login + register etc with this app is currently broken.
