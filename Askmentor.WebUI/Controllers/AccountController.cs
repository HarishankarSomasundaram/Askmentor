using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Askmentor.WebUI.Models;

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
 
        public string Login()
        {
            List<LoginViewModel> oLoginviewModel = new List<LoginViewModel>();

           oLoginviewModel = _LoginModel.GetAll();

           return "hello";
        }
        public ActionResult Register()
        {
            return View();

        }
	}
}