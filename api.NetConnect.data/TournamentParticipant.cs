//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace api.NetConnect.data
{
    using System;
    using System.Collections.Generic;
    
    public partial class TournamentParticipant
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public int TournamentID { get; set; }
        public int TournamentTeamID { get; set; }
        public System.DateTime Registered { get; set; }
        public byte[] LastChange { get; set; }
    
        public virtual Tournament Tournament { get; set; }
        public virtual TournamentTeam TournamentTeam { get; set; }
        public virtual User User { get; set; }
    }
}
