using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiteDB;
using PolitechFalkovskiyD.DAL.Model;

namespace PolitechFalkovskiyD.DAL
{
    public class RepositoryClient
    {
        //Метод, возвращающий список всех клиентов
        private readonly string path;

        public RepositoryClient(string path)
        {
            if (string.IsNullOrWhiteSpace(path))
                throw new ArgumentNullException("Путь к базе данных не может быть пустым");
            this.path = path;
        }
        public ReturnSesultClient GetAllClients()
        {
            ReturnSesultClient result = new ReturnSesultClient();
            try
            {
                
                using (var db = new LiteDatabase(path))
                {
                    result.Clients = db.GetCollection<Client>
                        ("Client").FindAll().ToList();
                }
            }
            catch(LiteException ex)
                when(string.IsNullOrWhiteSpace(path))
            {
                result.Exception = ex;
                result.IsError = true;
            }
            catch (Exception ex)
            {
                result.Exception = ex;
                result.IsError = true;
            }
            return result;
        }
        //Метод, возвращающий клиентов и ID
        public ReturnSesultClient GetClientById(int id)
        {

            ReturnSesultClient result = new ReturnSesultClient();
            try
            {
                using (var db = new LiteDatabase(path))
                {
                    result.Client = db.GetCollection<Client>("Client")
                    .FindById(id);
                }
            }
            catch (Exception ex)
            {
                result.Exception = ex;
                result.IsError = true;
            }
            return result;

        }
        //Метод, создающий клиента

        public ReturnSesultClient CreateClient(Client client)
        {
            ReturnSesultClient result = new ReturnSesultClient();
            try
            {


                using (var db = new LiteDatabase(path))
                {
                    var clients = db.GetCollection<Client>("Client");
                    clients.Insert(client);
                }
                
            }
            catch (Exception ex)
            {
                result.Exception = ex;
                result.IsError = true;
            }
            return result;
        }
        //Метод, обновляющий клиента
        //Метод, удаляющий клиента
    }
}
