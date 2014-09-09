using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Askmentor.DataEntity.User;

namespace Askmentor.Core.Service
{
  public interface IAccountService
    {
      List<User> GetAll();
    }
}
