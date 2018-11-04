The sample ASP.NET Core MVC application (created from `dotnet new mvc`) running from inside a Docker container.

## Build and run the Docker image
``` bash
docker build -t 02-web-app-mvc .
docker run -d -p 8080:80 02-web-app-mvc
```

Then open a web browser and go to localhost:8080.

Reference: https://docs.docker.com/engine/examples/dotnetcore/