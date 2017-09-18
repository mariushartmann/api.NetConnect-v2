﻿using api.NetConnect.data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace api.NetConnect.DataControllers
{
    public class UserDataController : GenericDataController<User>
    {
        public static User Update (User item)
        {
            User dbItem = GetItem(item.ID);

            dbItem.Newsletter = item.Newsletter;
            dbItem.BattleTag = item.BattleTag;
            dbItem.SteamID = item.SteamID;
            dbItem.Image = item.Image;
            dbItem.IsVorstand = item.IsVorstand;
            dbItem.IsAdmin = item.IsAdmin;
            dbItem.IsTeam = item.IsTeam;
            dbItem.Registered = item.Registered;
            dbItem.PasswordReset = item.PasswordReset;
            dbItem.Password = item.Password;
            dbItem.Email = item.Email;
            dbItem.Nickname = item.Nickname;
            dbItem.LastName = item.LastName;
            dbItem.FirstName = item.FirstName;

            db.SaveChanges();

            return dbItem;
        }
    }
}