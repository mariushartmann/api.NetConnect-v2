﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class NetConnectEntities : DbContext
    {
        public NetConnectEntities()
            : base("name=NetConnectEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CateringOrder> CateringOrder { get; set; }
        public virtual DbSet<CateringOrderDetail> CateringOrderDetail { get; set; }
        public virtual DbSet<CateringProduct> CateringProduct { get; set; }
        public virtual DbSet<Chat> Chat { get; set; }
        public virtual DbSet<Logs> Logs { get; set; }
        public virtual DbSet<Partner> Partner { get; set; }
        public virtual DbSet<PartnerPack> PartnerPack { get; set; }
        public virtual DbSet<Seat> Seat { get; set; }
        public virtual DbSet<Settings> Settings { get; set; }
        public virtual DbSet<Tournament> Tournament { get; set; }
        public virtual DbSet<TournamentGame> TournamentGame { get; set; }
        public virtual DbSet<TournamentParticipant> TournamentParticipant { get; set; }
        public virtual DbSet<TournamentTeam> TournamentTeam { get; set; }
        public virtual DbSet<User> User { get; set; }
    }
}
