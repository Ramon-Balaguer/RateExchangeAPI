﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ZebpayRateExchangeAPI.Models
{
    public class RequestModel
    {
        public string currencyCode { get; set; }
        public decimal amount { get; set; }
    }
}