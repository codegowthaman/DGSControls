using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DGSCONTROLS.MasterClasses.Accounts
{
    public interface  Ledger
    {
        long  LedgerNumber { get; set; }
        string LedgerName { get; set; }
        string LedgerSearchName{ get; set; }
        long LedgerGroupNumber { get; set; }
           
    }
}
