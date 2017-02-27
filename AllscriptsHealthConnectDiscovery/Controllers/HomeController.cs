using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace TestPatientApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Callback(string discovery)
        {
            var serializedModel = Encoding.Unicode.GetString(Convert.FromBase64String(HttpUtility.UrlDecode(discovery)));
            
            //here's the model object to work with
            var model = JsonConvert.DeserializeObject<Models.DiscoveryModel>(serializedModel);

            return Content(serializedModel);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        private string htmlEncode(object modelObject)
        {
            string theValue = null;

            if (modelObject != null)
            {
                var serializedModel = JsonConvert.SerializeObject(modelObject);
                theValue = HttpUtility.UrlEncode(Convert.ToBase64String(Encoding.Unicode.GetBytes(serializedModel)));
            }

            return theValue;
        }

        private string htmlDecode(string stringToDecode)
        {
            var theValue = HttpUtility.UrlDecode(stringToDecode);
            
            return theValue;
        }
    }
}