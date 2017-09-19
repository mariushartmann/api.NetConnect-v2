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
    
    public partial class Tournament
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tournament()
        {
            this.TournamentParticipant = new HashSet<TournamentParticipant>();
            this.TournamentTeam = new HashSet<TournamentTeam>();
        }
    
        public int ID { get; set; }
        public int Volume { get; set; }
        public int TournamentGameID { get; set; }
        public int TeamSize { get; set; }
        public string ChallongeLink { get; set; }
        public string Mode { get; set; }
        public System.DateTime Start { get; set; }
        public Nullable<System.DateTime> End { get; set; }
        public bool IsPauseGame { get; set; }
        public Nullable<int> PartnerID { get; set; }
        public byte[] LastChange { get; set; }
    
        public virtual Partner Partner { get; set; }
        public virtual TournamentGame TournamentGame { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TournamentParticipant> TournamentParticipant { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TournamentTeam> TournamentTeam { get; set; }
    }
}
