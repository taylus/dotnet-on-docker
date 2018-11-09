A rudimentary ASP.NET Core application running in one Docker container which communicates with a Postgres database running in a different container all managed using Docker Compose.

## Build and run the application
``` bash
docker-compose build && docker-compose up
```

Then open a web browser and go to localhost:8080.

### References:
* https://docs.docker.com/compose/overview/
* https://marketplace.visualstudio.com/items?itemName=Kelvin.vscode-sshfs (this extension is awesome, it made remotely editing code on my Linux server from my Windows desktop really easy)
* https://andrewlock.net/configuring-urls-with-kestrel-iis-and-iis-express-with-asp-net-core/ (for "why can't I see the app running on my other server")

### Why Postgres?
I dunno, I haven't used it since college and never with .NET so I thought it'd be interesting.
