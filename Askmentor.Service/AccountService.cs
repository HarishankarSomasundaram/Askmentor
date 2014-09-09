using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Askmentor.DataEntity.User;
using Askmentor.Infra;
using Askmentor.Core.Repository;
using Askmentor.Core.Service;

namespace Askmentor.Service
{
   public  class AccountService : IAccountService
    {
       public List<User> GetAll()
       {
           var AccountService = IoC.Resolve<IAccountRepository>();
           return AccountService.GetAll();
       }
    }
}
