using System;
using System.Data;
using Microsoft.AspNetCore.Mvc;
using Dapper;

namespace _03_docker_compose.Controllers
{
    public class HomeController : Controller
    {
        //use EF or a repository pattern or something in real-life... this is just a demo lol
        private readonly IDbConnection connection;

        public HomeController(IDbConnection connection)
        {
            this.connection = connection;
        }

        [Route("")]
        public IActionResult Index()
        {
            return Content(GetPostgresSystemInfo(connection));
        }

        //return a bunch of system information from the database
        //https://www.postgresql.org/docs/9.3/functions-info.html
        private static string GetPostgresSystemInfo(IDbConnection connection)
        {
            using (connection)
            {
                var info = connection.QuerySingle<dynamic>(
                    "select " +
	                "'You are connected to database \"' " +
	                "|| current_database() " +
	                "|| '\" as user \"' " +
	                "|| current_user " +
	                "|| '\" on host \"' " +
	                "|| inet_server_addr() " +
	                "|| '\" at port \"' " +
	                "|| inet_server_port() " +
	                "|| '\".' as server_info, " +
	                "'You are connecting from \"' " +
	                "|| inet_client_addr() " +
	                "|| '\" at port \"' " +
	                "|| inet_client_port() " +
	                "|| '\".' as client_info, " +
	                "'Version information: ' || version() as version_info;"
                );

                return info.server_info + Environment.NewLine + info.client_info + Environment.NewLine + info.version_info;
            }
        }
    }
}
