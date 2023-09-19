using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace PolitechFalkovskiyD.DAL.Model
{
    public class Client
    {
        /* int age;
        public int id
        {
            get
            {
                return id;
            }
            set
            {
                if (value < 0)
                    id = 0;
                else
                    id = value;
            }
        }

        public string FName { get;  set; } */

        public Client() :this(0) 
        {

        }
        public Client(int Id):this(Id, DateTime.Now)
        {
            
        }
        public Client(int Id, DateTime CreateDate):this(Id, CreateDate, "")
        {
            
        }
        public Client(int Id, DateTime CreateDate, string PathToImage)
        {
            this.Id = Id;
            this.CreateDate = CreateDate;
            this.PathToImage = PathToImage;
        }

        public int Id { get; set; }
        public DateTime CreateDate { get; set; }

        public string FName {  get; set; }
        public string SName { get; set; }
        public string LName { get; set; }

        public string FullName { 
            get 
            {
                return string.Format("{0} {1} {2}", FName, SName, LName);
            } 
        }

        public string ShortName { 
            get 
            {
                if (!string.IsNullOrWhiteSpace(LName))
                    return string.Format("{0} {1}. {2}.", FName, SName[0], LName[0]);
                else
                    return string.Format("{0} {1}. {2}.", FName, SName[0]);
                //return string.Format("{0} {1}. {2}.", FName, SName[0], !string.IsNullOrWhiteSpace(LName) != null ? LName[0].ToString());
            } 
        }

        public string PhoneNumber { get; set; }
        public int Sex { get; set; }

        public string PathToImage {  get; set; }
        public DateTime Dob { get; set; }

        public string Email {  get; set; }
        public string Password {  get; set; }

        public int Age
        {
            get
            {
                return (DateTime.Now.Year - Dob.Year);
            }
        }

        public Address Address { get; set; }

        public Account[] Accounts { get; set; }

    }


}
