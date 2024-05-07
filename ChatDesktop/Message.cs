using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatDesktop
{
    internal class Message
    {
        public int id { get; set; }
        public string message { get; set; }
        public string username { get; set; }
        public string? groupname { get; set; }
        public DateTime time { get; set; }
    }
}
