﻿using CRM.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VIETLIKE.Paging
{
    public class CustomerDataTableParamModel : jDataTableParamModel
    {
        public CustomerType customerType { get; set; }
    }
}
