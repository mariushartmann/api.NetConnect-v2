﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace api.NetConnect.data.ViewModel.Event
{
    public class EventViewModel : BaseViewModel
    {
        public EventViewModelItem Data { get; set; }

        public EventViewModel()
        {
            Data = new EventViewModelItem();
        }
    }

    public class EventViewModelItem : BaseViewModelItem
    {
        public String Title { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public String Image { get; set; }
        public String Description { get; set; }
        public String AddressLine1 { get; set; }
        public String AddressLine2 { get; set; }
        public String AddressLine3 { get; set; }
        public String RouteLink { get; set; }
        public Double Price { get; set; }

        public EventViewModelItem()
        {

        }
    }
}