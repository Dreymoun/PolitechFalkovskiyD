using PolitechFalkovskiyD.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolitechFalkovskiyD.DAL
{
    public class ReturnSesultClient
    {
        public bool IsError { get; set; } = false;
        public string Message { get; set; }
        public Exception Exception { get; set; }
        public Client Client { get; set; }
        public List<Client> Clients { get; set;}
    }
}
