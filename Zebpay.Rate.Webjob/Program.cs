﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Azure.WebJobs;
using RestSharp;

namespace Zebpay.Rate.Webjob
{
    // To learn more about Microsoft Azure WebJobs SDK, please see http://go.microsoft.com/fwlink/?LinkID=320976
    class Program
    {
        // Please set the following connection strings in app.config for this WebJob to run:
        // AzureWebJobsDashboard and AzureWebJobsStorage
     
        static void Main()
        {
            var host = new JobHost();
            Bootstrapper.Bootstrapper.Init();
            host.CallAsync(typeof(Functions).GetMethod("ProcessMethod"));
            // The following code ensures that the WebJob will be running continuously
            host.RunAndBlock();
        }

     
    }
}