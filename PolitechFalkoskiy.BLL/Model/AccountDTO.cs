using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace PolitechFalkovskiyD.BLL.Model
{
    public class AccountDTO
    {
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }

        public int ClientID { get; set; }
        public bool IsActive {  get; set; }
        public double Balance { get; set; }
        public int Currency {  get; set; }

        private string _number;
        public string Number { get
            {
                return _number;
            }
            set
            {
                if (!value.StartsWith("KZ"))
                    _number = "KZ" + value;
                else
                    _number = value;
            }
        }
        public DateTime ExpireDate {  get; set; }
        public int TypeAccount {  get; set; }

    }
}
