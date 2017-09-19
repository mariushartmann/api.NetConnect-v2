//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace api.NetConnect.data.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class Seat
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Seat()
        {
            this.CateringOrder = new HashSet<CateringOrder>();
        }
    
        public int ID { get; set; }
        public int UserID { get; set; }
        public int State { get; set; }
        public string Description { get; set; }
        public System.DateTime ReservationDate { get; set; }
        public bool Payed { get; set; }
        public bool IsTeam { get; set; }
        public bool IsActive { get; set; }
        public byte[] LastChange { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CateringOrder> CateringOrder { get; set; }
        public virtual User User { get; set; }
    }
}
