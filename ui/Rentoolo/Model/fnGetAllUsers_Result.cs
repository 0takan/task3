//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Rentoolo.Model
{
    using System;
    
    public partial class fnGetAllUsers_Result
    {
        public System.Guid UserId { get; set; }
        public string UserName { get; set; }
        public System.DateTime LastActivityDate { get; set; }
        public string Pwd { get; set; }
        public int PublicId { get; set; }
        public string Communication { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public string Email { get; set; }
    }
}