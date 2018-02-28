﻿using api.NetConnect.data.Entity;
using api.NetConnect.data.ViewModel.Event.Backend;
using api.NetConnect.data.ViewModel.User.Backend;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace api.NetConnect.data.ViewModel.Catering.Backend
{
    public class BackendCateringListArgs : ListArgsRequest<BackendCateringFilter>
    {
        public BackendCateringListArgs() : base()
        {

        }
    }

    public class BackendCateringListViewModel : ListArgsViewModel<BackendCateringViewModelItem, BackendCateringFilter>
    {
        public List<BackendCateringProductItem> ProductOptions { get; set; }

        public BackendCateringListViewModel() : base()
        {
            ProductOptions = new List<BackendCateringProductItem>();
        }
    }

    public class BackendCateringViewModel : BackendBaseViewModel
    {
        public BackendCateringViewModelItem Data { get; set; }
        public List<BackendEventViewModelItem> EventOptions { get; set; }
        public List<BackendCateringStatusOption> StatusOptions { get; set; }
        public List<BackendUserViewModelItem> UserOptions { get; set; }

        public BackendCateringViewModel()
        {
            Data = new BackendCateringViewModelItem();
            EventOptions = new List<BackendEventViewModelItem>();
            StatusOptions = new List<BackendCateringStatusOption>()
            {
                new BackendCateringStatusOption(0),
                new BackendCateringStatusOption(1),
                new BackendCateringStatusOption(2),
                new BackendCateringStatusOption(-1)
            };
            UserOptions = new List<BackendUserViewModelItem>();

            Form = GetForm();
        }

        public override Dictionary<string, InputInformation> GetForm()
        {
            return BackendCateringViewModelItem.GetForm();
        }
    }

    public class BackendCateringViewModelItem : BackendBaseViewModelItem
    {
        public BackendEventViewModelItem Event { get; set; }
        public BackendUserViewModelItem User { get; set; }
        public List<BackendCateringOrderItem> Order { get; set; }
        public Int32 SeatNumber { get; set; }
        public BackendCateringStatusOption Status { get; set; }
        public String Note { get; set; }

        public BackendCateringViewModelItem()
        {
            Event = new BackendEventViewModelItem();
            User = new BackendUserViewModelItem();
            Order = new List<BackendCateringOrderItem>();
            Status = new BackendCateringStatusOption(1);
        }

        public static Dictionary<string, InputInformation> GetForm()
        {
            Dictionary<string, InputInformation> result = new Dictionary<string, InputInformation>();

            result.Add("ID", new InputInformation() { Type = InputInformationType.integer, Readonly = true });
            result.Add("Status", new InputInformation() { Type = InputInformationType.choice, Required = true });
            result.Add("SeatNumber", new InputInformation() { Type = InputInformationType.integer, Required = true, Readonly = true });
            result.Add("Event", new InputInformation() { Type = InputInformationType.reference, Reference = "Event", ReferenceForm = Form.GetReferenceForm(BackendEventViewModelItem.GetForm()), Required = true, Readonly = true });
            result.Add("User", new InputInformation() { Type = InputInformationType.reference, Reference = "User", ReferenceForm = Form.GetReferenceForm(BackendUserViewModelItem.GetForm()), Required = true, Readonly = true });
            result.Add("Note", new InputInformation() { Type = InputInformationType.text });

            return result;
        }
    }

    public class BackendCateringStatusOption
    {
        public Int32 Key { get; set; }
        public String Text { get; set; }

        public BackendCateringStatusOption(Int32 Status)
        {
            Key = Status;
            switch(Status)
            {
                case 0:
                    Text = "Neu";
                    break;
                case 1:
                    Text = "Bezahlt";
                    break;
                case 2:
                    Text = "Fertig";
                    break;
                case -1:
                    Text = "Storniert";
                    break;
            }
        }
    }

    public class BackendCateringSeat
    {
        public String Name { get; set; }
        public Int32 SeatNumber { get; set; }
    }

    public class BackendCateringOrderItem : BackendBaseViewModelItem
    {
        public String Name { get; set; }
        public List<String> Attributes { get; set; }
        public Int32 Amount { get; set; }
        public Decimal Price { get; set; }
    }

    public class BackendCateringProductItem : BackendBaseViewModelItem
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public List<ProductAttributeViewModelItem> Attributes { get; set; }
        public bool SingleChoice { get; set; }
    }
}