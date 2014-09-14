using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Askmentor.WebUI.Models;
using System.Globalization;

namespace Askmentor.WebUI.Controllers
{
    public class AccountController : Controller
    {
        private LoginModel _LoginModel;

        public AccountController()
        {
            _LoginModel = new LoginModel();
        }
        public ActionResult Index()
        {
            return View();
        }
 
        public ActionResult Login()
        {
            LoginViewModel oLoginviewModel = new LoginViewModel();
           //List<LoginViewModel> oLoginviewModel = new List<LoginViewModel>();
           //oLoginviewModel = _LoginModel.GetAll();

            return View(oLoginviewModel);
        }
        [HttpPost]
        public ActionResult Login(LoginViewModel oLoginviewModel)
        {
            if (ModelState.IsValid)
            {

            }
            if (_LoginModel.isUserValid(oLoginviewModel))
            {
 
            }
            return View(oLoginviewModel);
        }


        public JsonResult IsEmailIDExists(string EmailID)
            {

            if (_LoginModel.isUserExists(EmailID))
            {
                  return Json(true, JsonRequestBehavior.AllowGet);
            }
             
            string suggestedUID = String.Format(CultureInfo.InvariantCulture,
                "{0} is not available.", EmailID);            
            return Json(suggestedUID, JsonRequestBehavior.AllowGet);
        }


        public ActionResult Register()
        {
            return View();

        }
	}
}