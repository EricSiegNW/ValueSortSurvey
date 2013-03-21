using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ValueSortSurvey.DataLayer;
using ValueSortSurvey.Services;

namespace ValueSortSurvey.Controllers {
    public partial class HomeController : Controller {
        //
        // GET: /Home/
        SurveyContext db = new SurveyContext();

        public virtual ActionResult Index() {
            return View();
        }

        public virtual ActionResult StartSurvey() {
            ISurveyHandler handler = new DbInitSurveyHandler(); // should have a factory or something for this, but hardcoding works for now. DI maybe?
            var model = handler.PopulateInitialSurvey("ABC");
            return View(model);
        }

        [HttpPost]
        public virtual string FormTest(string input) {
            return "submitted";
        }

        public virtual ActionResult FormTest() {
            return View();
        }

        [HttpPost]
        public virtual string PostSurvey(FormCollection formValues, string UserId) {
            int i = 0;
            string result = "";
            result += "User Id of Awesomeness: " + UserId + "<br />";
            formValues.Remove("UserId");
            foreach (var key in formValues.AllKeys) {
                result += "Index: " + i.ToString() + " Key: " + key + " Value: " + formValues[key] + ". <br />";
                i++;
            }
            return result;
        }

    }
}
