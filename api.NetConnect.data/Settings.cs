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
    
    public partial class Settings
    {
        public int ID { get; set; }
        public int Volume { get; set; }
        public double ReservationCost { get; set; }
        public System.DateTime Start { get; set; }
        public System.DateTime End { get; set; }
        public int IsActiveReservation { get; set; }
        public System.DateTime BankAccountCheck { get; set; }
        public int ReservedDays { get; set; }
        public bool IsActiveCatering { get; set; }
        public bool IsActiveFeedback { get; set; }
        public string FeedbackLink { get; set; }
        public bool IsActiveChat { get; set; }
        public string BankAccountOwner { get; set; }
        public string IBAN { get; set; }
        public string BLZ { get; set; }
        public string BankAccountNumber { get; set; }
        public string BIC { get; set; }
        public byte[] LastChange { get; set; }
    }
}
