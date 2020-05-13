using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV6_Rppoon
{
    class BankAccountMemento
    {
        public string ownerName { get; private set; }
        public string ownerAddress { get; private set; }
        public decimal balance { get; private set; }
        public DateTime CreationTime { get; private set; }

        public BankAccountMemento(BankAccount x)
        {
            this.ownerName = x.OwnerName;
            this.ownerAddress = x.OwnerAddress;
            this.balance = x.Balance;
            CreationTime = DateTime.Now;

        }
    }
}
