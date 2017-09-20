﻿using api.NetConnect.data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace api.NetConnect.DataControllers
{
    public class TournamentDataController : GenericDataController<Tournament>
    {
        public static Tournament Update(Tournament item)
        {
            Tournament dbItem = GetItem(item.ID);

            dbItem.Volume = item.Volume;
            dbItem.TournamentGameID = item.TournamentGameID;
            dbItem.TeamSize = item.TeamSize;
            dbItem.ChallongeLink = item.ChallongeLink;
            dbItem.Mode = item.Mode;
            dbItem.Start = item.Start;
            dbItem.End = item.End;
            dbItem.IsPauseGame = item.IsPauseGame;
            dbItem.PartnerID = item.PartnerID;

            db.SaveChanges();

            return dbItem;
        }
    }

    public class TournamentGameDataController : GenericDataController<TournamentGame>
    {
        public static TournamentGame Update(TournamentGame item)
        {
            TournamentGame dbItem = GetItem(item.ID);

            dbItem.Name = item.Name;
            dbItem.Icon = item.Icon;
            dbItem.Rules = item.Rules;
            dbItem.BattleTag = item.BattleTag;
            dbItem.SteamID = item.SteamID;

            db.SaveChanges();

            return dbItem;
        }
    }

    public class TournamentParticipantDataController : GenericDataController<TournamentParticipant>
    {
        public static TournamentParticipant Update(TournamentParticipant item)
        {
            TournamentParticipant dbItem = GetItem(item.ID);

            dbItem.UserID = item.UserID;
            dbItem.TournamentID = item.TournamentID;
            dbItem.TournamentTeamID = item.TournamentTeamID;
            dbItem.Registered = item.Registered;

            db.SaveChanges();

            return dbItem;
        }
    }

    public class TournamentTeamDataController : GenericDataController<TournamentTeam>
    {
        public static TournamentTeam Update(TournamentTeam item)
        {
            TournamentTeam dbItem = GetItem(item.ID);

            dbItem.Name = item.Name;
            dbItem.TournamentID = item.TournamentID;
            dbItem.Password = item.Password;

            db.SaveChanges();

            return dbItem;
        }
    }
}