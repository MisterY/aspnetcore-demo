using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Config
{
    public class StuffConfig
    {
        public Server Server { get; set; }
        public Credentials Credentials { get; set; }
    }

    public class Server
    {
        public string Host { get; set; }
        public int Port { get; set; }
    }

    public class Credentials
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
