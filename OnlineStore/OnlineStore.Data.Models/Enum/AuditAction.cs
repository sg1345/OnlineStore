using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Data.Models.Enum
{
    public enum AuditAction
    {
        Created = 1,
        Updated = 2,
        Deleted = 3,
        StatusChanged = 4,
        Login = 5,
        Logout = 6,
        PaymentProcessed = 7,
        PaymentFailed = 8
    }
}
