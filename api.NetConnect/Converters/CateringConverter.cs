﻿using api.NetConnect.data.Entity;
using api.NetConnect.data.ViewModel.Catering;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace api.NetConnect.Converters
{
    public static partial class ConverterExtensions
    {
        public static ProductViewModelItem FromModel(this ProductViewModelItem viewModel, CateringProduct model)
        {
            viewModel.ID = model.ID;
            viewModel.Name = model.Name;
            viewModel.Price = model.Price;
            viewModel.SingleChoice = model.SingleChoice;
            viewModel.Image = Properties.Settings.Default.imageAbsolutePath + model.ImageContainer.OriginalPath;

            var vm = new ProductAttributeViewModelItem();
            List<ProductAttributeViewModelItem> atts = new List<ProductAttributeViewModelItem>();
            foreach (var at in model.CateringProductAttributeRelation)
                atts.Add(new ProductAttributeViewModelItem().FromModel(at.CateringProductAttribute));

            viewModel.ProductAttribute = atts;

            return viewModel;
        }

        public static ProductAttributeViewModelItem FromModel(this ProductAttributeViewModelItem viewModel, CateringProductAttribute model)
        {
            viewModel.ID = model.ID;
            viewModel.Name = model.Name;

            return viewModel;
        }

        public static CateringOrder ToModel(this OrderRequest viewModel)
        {
            CateringOrder model = new CateringOrder();

            model.UserID = viewModel.UserID;
            model.SeatID = viewModel.SeatID;
            model.EventID = viewModel.EventID;

            model.CateringOrderDetail = viewModel.Items.ConvertAll(x =>
            {
                return x.ToModel();
            });

            return model;
        }

        public static CateringOrderDetail ToModel(this OrderRequest.OrderRequestItem viewModel)
        {
            CateringOrderDetail model = new CateringOrderDetail();

            model.CateringProductID = viewModel.ID;
            model.Attributes = JsonConvert.SerializeObject(viewModel.Attributes);
            model.Amount = viewModel.Amount;

            return model;
        }
    }
}