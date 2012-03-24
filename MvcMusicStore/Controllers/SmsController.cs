﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Twilio.TwiML.Mvc;
using Twilio.TwiML;

namespace MvcMusicStore.Controllers
{
    public class SmsController : TwilioController
    {
        MvcMusicStore.Models.MusicStoreEntities db = new Models.MusicStoreEntities();
        //
        // GET: /Sms/

        public ActionResult Index(String Body)
        {
            return View();           
        }

    }
}
