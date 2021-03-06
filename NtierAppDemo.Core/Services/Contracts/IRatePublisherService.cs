﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NtierAppDemo.Core.Entities;

namespace NtierAppDemo.Core.Services.Contracts
{
    public interface IRatePublisherService:IService
    {
        RatePublisher GetRate(string currancyCode);

        bool Add(RatePublisher rate);
    }
}
