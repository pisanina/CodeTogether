//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CodeTogether.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class tblUserData
    {
        public int ID              { get; set; }
        public string UserName     { get; set; }
        public string Email        { get; set; }
        [DataType(DataType.Password)]
        public string UserPassword { get; set; }
        public string FirstName    { get; set; }
        public string LastName     { get; set; }
        public string Gender       { get; set; }
        public int AddressID       { get; set; }
        public Nullable<System.DateTime> BirthDate { get; set; }

        public virtual tblAddress tblAddress { get; set; }
    }
}
