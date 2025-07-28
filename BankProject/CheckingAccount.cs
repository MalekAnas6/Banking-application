using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankProject
{
    public class CheckingAccount : Account
    {
        public CheckingAccount(Client owner) : base(owner, AccountType.Checking) {}
    } 
}
