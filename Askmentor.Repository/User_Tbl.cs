//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Askmentor.Repository
{
    using System;
    using System.Collections.Generic;
    
    public partial class User_Tbl
    {
        public int User_mID { get; set; }
        public string User_ID { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string Short_Name { get; set; }
        public int Role_ID { get; set; }
        public int Created_By { get; set; }
        public System.DateTime Created_Date { get; set; }
        public Nullable<int> Modified_By { get; set; }
        public Nullable<System.DateTime> Modified_Date { get; set; }
        public Nullable<decimal> Contact_Number { get; set; }
        public string IPAddress { get; set; }
        public Nullable<System.DateTime> LastLogon_Time { get; set; }
        public string Server_Name { get; set; }
        public bool Active { get; set; }
    }
}
