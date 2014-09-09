using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Askmentor.DataEntity.User;
using Askmentor.Core.Repository;
using Askmentor.Core.Service;

namespace Askmentor.Repository
{
    public class AccountRepository : IAccountRepository
    {
        private AskMentorDBContainer _askmentorEntities = null;
        public AccountRepository()
        {
            _askmentorEntities = new AskMentorDBContainer();
        }
        public List<DataEntity.User.User> GetAll()
        {
            return _askmentorEntities.Users
                .Where(x => x.IsActive == true && x.IsDeleted == false)
                .Select(x => new DataEntity.User.User
                {
                    UserID = x.UserID,
                    UserName = x.UserName,
                    Password = x.Password,
                    EmailID = x.EmailID,
                    FirstName = x.FirstName,
                    LastName = x.LastName,
                    PhoneNumber = x.PhoneNumber,
                    ModifiedDate = x.ModifiedDate,
                    LastLogonTIme = x.LastLogonTIme,
                    LastIPAddress = x.LastIPAddress                   
                })
                .ToList();
        }

    }
}
