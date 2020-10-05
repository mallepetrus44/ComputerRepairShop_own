using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerRepairShop.Data.Models
{
    public enum Status
    {
        None,
        Pending,
        WaitingOnParts,
        Ready,
        Delayed
    }
}
