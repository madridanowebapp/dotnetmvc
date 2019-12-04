using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SharpDevelopMVC4.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
		ViewBag.Message = "Hello message from Index!";
            return View();
        }

        public ActionResult About()
        {

        	ViewBag.Message = "Hello message from about!";
            return View();
        }

        public ActionResult Contact()
        {

			ViewBag.Message = "Hello message from Contact!";
            return View();
        }
        public ActionResult Input()
        {

			ViewBag.Message = "Hello message from Input!";
            return View();
        }
        public ActionResult TransferSave(  
            string firstname,
			string lastname,
			string transactionType,
			string amount,
			string message,
			string radioBtnTransactOption,
			string dateTransfer)
        {
	
			ViewBag.Firstname = firstname;
			ViewBag.Lastname = lastname;
			ViewBag.TransactionType = transactionType;
			ViewBag.Amount = amount;
			ViewBag.Message = message;
			ViewBag.Transaction = radioBtnTransactOption;	
			ViewBag.DateOfTransfer = dateTransfer;	
            return View();
        }
         
        public ActionResult Transfer()
        {
        	return View();
		}
    }
}