﻿using api.NetConnect.data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using api.NetConnect.data.ViewModel.Partner;
using api.NetConnect.data.ViewModel.Partner.Backend;

namespace api.NetConnect.Converters
{
    public static partial class ConverterExtensions
    {
        #region Frontend
        public static void FromModel(this PartnerViewModelItem viewModel, Partner model)
        {
            viewModel.Name = model.Name;
            viewModel.Description = model.Content;
            viewModel.Image = model.ImageContainer.OriginalPath;
            viewModel.Link = model.Link;
            viewModel.RefLink = model.Link;

            viewModel.PartnerType = new PartnerType()
            {
                Name = model.PartnerPack.Name
            };

            // TODO Nachfolgendes
            string[] displays = { "Header", "Footer" };
            foreach (var display in displays)
                viewModel.Display.Add(new data.ViewModel.Partner.PartnerDisplay() { ID = 1, Name = display, Value = true });
        }

        public static void FromViewModel(this Partner model, PartnerViewModelItem viewModel)
        {
            viewModel.ID = model.ID;
            viewModel.Name = model.Name;
            viewModel.Description = model.Content;
            viewModel.Link = model.Link;
            viewModel.RefLink = model.RefLink;
            viewModel.Image = "";

            viewModel.PartnerType = new PartnerType()
            {
                ID = model.PartnerPack.ID,
                Name = model.PartnerPack.Name
            };

            foreach (var displayRelation in model.PartnerDisplayRelation)
            {
                viewModel.Display.Add(new data.ViewModel.Partner.PartnerDisplay()
                {
                    ID = displayRelation.PartnerDisplay.ID,
                    Name = displayRelation.PartnerDisplay.Name,
                    Value = true
                });
            }
        }
        #endregion
        #region Backend
        public static void FromModel(this BackendPartnerViewModelItem viewModel, Partner model)
        {
            DataContext db = InitDB();

            viewModel.ID = model.ID;
            viewModel.Name = model.Name;
            viewModel.Description = model.Content;
            viewModel.Link = model.Link;
            viewModel.RefLink = model.RefLink;
            viewModel.Image = "";
            viewModel.IsActive = model.IsActive;

            viewModel.PartnerTypeSelected = new PartnerType()
            {
                ID = model.PartnerPack.ID,
                Name = model.PartnerPack.Name
            };
            
            foreach (var display in db.PartnerDisplay)
            {
                if(model.PartnerDisplayRelation.FirstOrDefault(x => x.PartnerID == model.ID && x.PartnerDisplayID == display.ID) != null)
                    viewModel.Display.Add(new data.ViewModel.Partner.PartnerDisplay()
                    {
                        ID = display.ID,
                        Name = display.Name,
                        Value = true
                    });
                else
                    viewModel.Display.Add(new data.ViewModel.Partner.PartnerDisplay()
                    {
                        ID = display.ID,
                        Name = display.Name,
                        Value = false
                    });
            }
        }

        public static void FromViewModel(this Partner model, BackendPartnerViewModelItem viewModel)
        {
            DataContext db = InitDB();

            model.ID = viewModel.ID;
            model.Name = viewModel.Name;
            model.Content = viewModel.Description;
            model.Link = viewModel.Link;
            model.RefLink = viewModel.RefLink;
            //model.Image = viewModel.Image;
            model.IsActive = viewModel.IsActive;

            model.PartnerPackID = viewModel.PartnerTypeSelected.ID;

            foreach (var display in viewModel.Display)
                model.PartnerDisplayRelation.Add(new PartnerDisplayRelation()
                {
                    PartnerID = viewModel.ID,
                    PartnerDisplayID = display.ID
                });
        }
        #endregion
    }
}