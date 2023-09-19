using PolitechFalkovskiyD.DAL;
using PolitechFalkovskiyD.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolitechFalkovskiyD.Online.View
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();
            client.CreateDate = DateTime.Now;
            client.Dob = new DateTime(2002, 02, 28);
            client.Email = "dmitriy.02@list.ru";
            client.LName = "Olegovich";
            client.FName = "Dmitriy";
            client.SName = "Falkovskiy";
            client.Password ="password";

            ServiceClient service = new ServiceClient();
            service.CreateClient(client);
        }
    }
}
