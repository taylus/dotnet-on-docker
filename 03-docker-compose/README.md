A rudimentary ASP.NET Core application running in one Docker container which communicates with a Postgres database running in a different container all managed using Docker Compose.

## Build and run the application
``` bash
docker-compose build && docker-compose up
```

Then open a web browser and go to localhost:8080 and you should see a page like this:

```
You are connected to database "postgres" as user "postgres" on host "172.20.0.2/32" at port "5432".
You are connecting from "172.20.0.3/32" at port "32842".
Version information: PostgreSQL 11.0 (Debian 11.0-1.pgdg90+2) on x86_64-pc-linux-gnu, compiled by gcc (Debian 6.3.0-18+deb9u1) 6.3.0 20170516, 64-bit
```

### References:
* https://docs.docker.com/compose/overview/
* https://marketplace.visualstudio.com/items?itemName=Kelvin.vscode-sshfs (this extension is awesome, it made remotely editing code on my Linux server from my Windows desktop really easy)
* https://andrewlock.net/configuring-urls-with-kestrel-iis-and-iis-express-with-asp-net-core/ (for "why can't I see the app running on my other server")

### Why Postgres?
I dunno, I haven't used it since college and never with .NET so I thought it'd be interesting.
