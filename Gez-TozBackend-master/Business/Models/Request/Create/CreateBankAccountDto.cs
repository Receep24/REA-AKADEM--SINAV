﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Request.Create
{
    public class CreateBankAccountDto
    {
        public string AccountNumber { get; set; }
        public decimal Balance { get; set; }
        public int UserID { get; set; }
    }
}
