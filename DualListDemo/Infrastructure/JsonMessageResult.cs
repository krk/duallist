using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DualListDemo.Infrastructure
{
    public class JsonMessageResult : JsonResult
    {
        //return Json(new { message = "User not deleted.", error = true }, JsonRequestBehavior.AllowGet);

        public string Message { get; set; }
        public JsonResultMessageType MessageType { get; set; }
        public bool IsForceReload { get; set; }

        public JsonMessageResult()
        {
            JsonRequestBehavior = System.Web.Mvc.JsonRequestBehavior.AllowGet;
        }

        public override void ExecuteResult(ControllerContext context)
        {
            Data = new { message = Message, type = MessageType.ToString().ToLower(), forceReload = IsForceReload };
            base.ExecuteResult(context);
        }
    }
}