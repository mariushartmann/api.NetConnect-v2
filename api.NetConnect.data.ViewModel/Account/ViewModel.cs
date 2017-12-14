﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace api.NetConnect.data.ViewModel.Account
{
    public class AccountViewModel : BaseViewModel
    {
        public AccountViewModelItem Data { get; set; }

        public AccountViewModel()
        {
            Data = new AccountViewModelItem();
        }
    }

    public class AccountViewModelItem : BaseViewModelItem
    {
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String Nickname { get; set; }
        public String Email { get; set; }
        public String Image { get; set; }
        public String SteamID { get; set; }
        public String BattleTag { get; set; }
        public Boolean Newsletter { get; set; }
        public String OldPassword { get; set; }
        public String NewPassword1 { get; set; }
        public String NewPassword2 { get; set; }

        public AccountViewModelItem()
        {
        }
    }
}