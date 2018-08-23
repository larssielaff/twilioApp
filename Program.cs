using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;
using Twilio.TwiML;
using Twilio.AspNet.Mvc;
/*
*/
using System.Web;
using System.Web.Mvc;
using System.Configuration;

namespace TwilioApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
            // running on startup! 
            const string accountSid = "AC4b55ab71e6906b2a91eeda1e31c9cf2c";
            const string authToken = "b5145aadd0804516334164288f3180a9";
            TwilioClient.Init(accountSid, authToken);
/*
            var to = new PhoneNumber("+491622635430");
            var from = new PhoneNumber("+4915735991409");
            var message = MessageResource.Create(
                to: to,
                from: from,
                body: "miep moep SMS!!!");

            Console.WriteLine(message.Sid);
            */
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();

        
    }
}
