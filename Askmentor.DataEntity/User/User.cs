using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Askmentor.DataEntity.User
{
   public class User
    {
       public int UserID { get; set; }
       public String UserName { get; set; }
       public string Password { get; set; }
       public string EmailID { get; set; }
       public string FirstName { get; set; }
       public string LastName { get; set; }
       public int? PhoneNumber { get; set; }
       public DateTime ModifiedDate { get; set; }
       public DateTime LastLogonTIme {get; set;}
       public string LastIPAddress{get; set;}
       public bool? IsActive {get; set;}
       public bool? IsDeleted{get; set;}
       
       }
}
