﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace api.NetConnect.data.ViewModel.Navigation
{
    public class NavigationViewModel : BaseViewModel
    {
        public NavigationViewModelItem Data { get; set; }

        public NavigationViewModel()
        {
            Data = new NavigationViewModelItem();
        }
    }

    public class NavigationViewModelItem : BaseViewModelItem
    {
        public List<NavItem> NavigationUser { get; set; }
        public List<NavItem> NavigationTop { get; set; }
        public List<NavItem> NavigationAside { get; set; }
        public List<NavItem> NavigationBottom { get; set; }

        public NavigationViewModelItem()
        {
            NavigationUser = new List<NavItem>();
            NavigationTop = new List<NavItem>();
            NavigationAside = new List<NavItem>();
            NavigationBottom = new List<NavItem>();
        }
    }

    public class NavItem
    {
        public String Text { get; set; }
        public String State { get; set; }
        public String StateCompare { get; set; }
        public List<NavItem> SubMenu { get; set; }
    }
}