using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ManagementApplication
{
    class Connection
    {
        byte[] buffer = new byte[1000];
        byte[] msg = Encoding.ASCII.GetBytes("From server\n");
        string data = null;

       
    }
}
