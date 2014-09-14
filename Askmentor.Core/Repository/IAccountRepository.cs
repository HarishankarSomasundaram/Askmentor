using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Askmentor.DataEntity.User;
namespace Askmentor.Core.Repository
{
  public interface IAccountRepository
    {
      List<User> GetAll();
      bool Get(string EmailID);
      bool ValidateUser(string Email, string Password);
    }
}
