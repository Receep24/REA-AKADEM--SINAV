﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Request.Update
{
    public class TransactionUpdateDTO
    {
        public int AccountID { get; set; }
        public DateTime TransactionDate { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
    }
}
