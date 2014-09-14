using Askmentor.Core.Repository;
using Askmentor.DataEntity;
using Askmentor.Infra;
using Askmentor.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;



namespace Askmentor.WebUI.Models
{
    public class ExternalLoginConfirmationViewModel
    {
        [Required]
        [Display(Name = "User name")]
        public string UserName { get; set; }
    }

    public class ManageUserViewModel
    {
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Current password")]
        public string OldPassword { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "New password")]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm new password")]
        [Compare("NewPassword", ErrorMessage = "The new password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }

    public class LoginViewModel
    {
        [Required]
        [System.Web.Mvc.Remote("IsEmailIDExists", "Account")]
        [RegularExpression(@"(\S)+", ErrorMessage = "White space is not allowed.")]
        [Display(Name = "Email ID")]
        public string EmailID { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }
        

    }
    public class LoginUser
    {
        public List<LoginViewModel> UsersList { get; set; }
    }

    public class RegisterViewModel
    {
        [Required]
        [Display(Name = "User name")]
        public string UserName { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }

   

    public class LoginModel
    {
        //List<RoleViewModel> oRoles = new List<RoleViewModel>();
        // var roleRepo = IoC.Resolve<IRoleService>();
        // var roleList = roleRepo.GetAll();
        // foreach (var item in roleList)
        // {
        //     RoleViewModel oRole = new RoleViewModel();
        //     oRole.Description = item.Description;
        //     oRole.Name = item.Name;
        //     oRole.RoleId = item.RoleId;
        //     oRoles.Add(oRole);
        // }
        // return oRoles;

        public bool isUserValid(LoginViewModel oLoginviewModel)
        {
            var accountRepo = IoC.Resolve<IAccountRepository>();
            return accountRepo.ValidateUser(oLoginviewModel.EmailID, oLoginviewModel.Password);
        }

        public bool isUserExists(string EmailID)
        {
            var accountRepo = IoC.Resolve<IAccountRepository>();
            return accountRepo.Get(EmailID);
        }

        public List<LoginViewModel> GetAll()
        {
            List<LoginViewModel> userDetails = new List<LoginViewModel>();
            var accountRepo = IoC.Resolve<IAccountRepository>();
            var userList = accountRepo.GetAll();
            foreach(var item in userList)
            {
                LoginViewModel oLogin = new LoginViewModel();
                oLogin.EmailID = item.EmailID;
                oLogin.Password = item.Password;
                userDetails.Add(oLogin);
            }
            return userDetails;
        }


    }
}
