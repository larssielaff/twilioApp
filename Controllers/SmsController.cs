//using System.Web.Mvc;

//using Microsoft.AspNetCore.Mvc.Rendering;
/*
using Twilio.TwiML;
using Twilio.AspNet.Mvc;

using System.Net.Http;

using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;


namespace TwilioApp.Controllers
{
    public class SmsController : TwilioController
    {
        /*
        // GET: SMS
        public ActionResult SendSms()
        {
            const string accountSid = "AC4b55ab71e6906b2a91eeda1e31c9cf2c";
            const string authToken = "b5145aadd0804516334164288f3180a9";
            TwilioClient.Init(accountSid, authToken);

            var to = new PhoneNumber("+491622635430");
            var from = new PhoneNumber("+4915735991409");
            var message = MessageResource.Create(
                to: to,
                from: from,
                body: "wupp wupp SMS!!!");

            Console.WriteLine(message.Sid);
            return Content(message.Sid);
        }

        public ActionResult ReceiveSms()
        {
            var response = new MessagingResponse();
            response.Message("sms received!");
            return TwiML(response);
        }
        public string ReceiveSms()
        {
            string xxx = "";

            return xxx;
        }
        
        //[HttpPost]
        public TwiMLResult Index()
        {
            var messagingResponse = new MessagingResponse();
            messagingResponse.Message("The Robots are coming! Head for the hills!");

            return TwiML(messagingResponse);
        }*/
/*    } 
}*/