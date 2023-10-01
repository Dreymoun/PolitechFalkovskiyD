using PolitechFalkovskiyD.DAL;
using PolitechFalkovskiyD.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolitechFalkovskiyD.BLL
{
    public class ServiceClient
    {
        private readonly string path = "";
        public ServiceClient(string path) 
        {
            this.path = path;
        }
        public (bool isError, string message) RegisterClient(Client client)
        {
            RepositoryClient repo = new RepositoryClient(path);
            ReturnSesultClient result = repo.CreateClient(client);
            return (result.IsError, result.Exception!=null ? result.Exception.Message : "");
        }

        public void AuthorizationClient(Client client)
        {
            RepositoryClient repo = new RepositoryClient(path);
            ReturnSesultClient result = repo.GetClient(client.Email client.Password);

            return result.Client;
        }
    }
}
