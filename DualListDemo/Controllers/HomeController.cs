using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DualListDemo.Infrastructure;

namespace DualListDemo.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public HomeController()
        {
            DualListHandler = new DualListDump();
        }

        public ActionResult Index()
        {
            return View();
        }

        public IDualListHandler DualListHandler { get; set; }

        public ActionResult UpdateList(string cid, string lid, string id)
        {
            return new JsonMessageResult()
            {
                Message = string.Format("UpdateList: containerId: {0}, listId: {1}, itemId: {2}", cid, lid, id),
                MessageType = JsonResultMessageType.Success
            };
        }

        [HttpPost]
        public ActionResult SubmitLists(
            string containerId,
            List<int> orig1,
            List<int> orig2,
            List<int> new1,
            List<int> new2)
        {
            var addedTo1 = new1.Except(orig1).ToArray();
            var removedFrom1 = orig1.Except(new1).ToArray();
            var addedTo2 = new2.Except(orig2).ToArray();
            var removedFrom2 = orig2.Except(new2).ToArray();

            DualListHandler.Handle(addedTo1, removedFrom1, addedTo2, removedFrom2);

            return new JsonMessageResult()
            {
                Message = string.Format("Results submitted. containerId: {0}.", containerId),
                MessageType = JsonResultMessageType.Success
            };
        }

    }
}
