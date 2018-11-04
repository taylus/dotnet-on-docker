The sample "Hello World!" .NET Core console application (created from `dotnet new console`) running from inside a Docker container.

## Build and run the Docker image
``` bash
docker build -t 01-console-app .
docker run --rm 01-console-app
```

Reference: https://docs.docker.com/engine/examples/dotnetcore/