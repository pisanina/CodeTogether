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
    
    public partial class tblAddress
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblAddress()
        {
            this.tblUserData = new HashSet<tblUserData>();
        }
    
        public int ID         { get; set; }
        public string Country { get; set; }
        public string Region  { get; set; }
        public string City    { get; set; }
        public string ZipCode { get; set; }
        public string Street  { get; set; }
        public Nullable<int> Number { get; set; }
        public Nullable<int> ApartmentNumber { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblUserData> tblUserData { get; set; }
    }
}
