//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class RequestState
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RequestState()
        {
            this.RequestStateHistory = new HashSet<RequestStateHistory>();
        }
    
        public int Id { get; set; }
        public string Name_ru { get; set; }
        public string Name_kg { get; set; }
        public string Description_ru { get; set; }
        public string Description_kg { get; set; }
        public string CODE { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RequestStateHistory> RequestStateHistory { get; set; }
    }
}
