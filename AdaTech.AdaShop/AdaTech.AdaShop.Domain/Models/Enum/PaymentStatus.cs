﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaTech.AdaShop.Domain.Models.Enum
{
    public enum PaymentStatus
    {
        Approved = 1,
        Pending,
        Failed,
        Canceled,
    }
}
