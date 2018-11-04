The sample "Hello World!" ASP.NET Core MVC application (created from `dotnet new mvc`) running from inside a Docker container.

## Build and run the Docker image
``` bash
docker build -t 02-web-app-mvc
docker run -d -p 8080:80 02-web-app-mvc
```

Reference: https://docs.docker.com/engine/examples/dotnetcore/