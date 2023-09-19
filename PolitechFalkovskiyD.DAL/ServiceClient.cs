using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiteDB;
using PolitechFalkovskiyD.DAL.Model;

namespace PolitechFalkovskiyD.DAL
{
    public class ServiceClient
    {
        //Метод, возвращающий список всех клиентов

        public List<Client> GetAllClients()
        {
            List<Client> clients = null;
            using (var db = new LiteDatabase(@"C:\Temp\MyData.db"))
            {
                clients = db.GetCollection<Client>("Client")
                    .FindAll()
                    .ToList();
            }
            return clients;
            
        }
        //Метод, возвращающий клиентов и ID
        public Client GetClientById(int id)
        {
            Client client = null;
            using (var db = new LiteDatabase(@"C:\Temp\MyData.db"))
            {
                client = db.GetCollection<Client>("Client")
                    .FindById(id);
            }
            return client;
        }
        //Метод, создающий клиента

        public bool CreateClient(Client client)
        {
            using (var db = new LiteDatabase(@"C:\Temp\MyData.db"))
            {
                var clients = db.GetCollection<Client>("Client");
                clients.Insert(client);
            }
            return true;
        }
        //Метод, обновляющий клиента
        //Метод, удаляющий клиента
    }
}
