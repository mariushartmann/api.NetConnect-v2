﻿using api.NetConnect.data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using api.NetConnect.data.ViewModel.Seating;
using api.NetConnect.data.ViewModel;
using api.NetConnect.DataControllers;

namespace api.NetConnect.Converters
{
    using SeatingListViewModel = ListArgsViewModel<SeatingViewModelItem, SeatingFilter, SeatingSortSettings>;
    using SeatingArgsRequest = ListArgsRequest<SeatingFilter, SeatingSortSettings>;

    public static partial class ConverterExtensions
    {
        public static void FromModel(this SeatingViewModelItem viewModel, Seat model)
        {
            viewModel.ID = model.ID;
            viewModel.ReservationState = model.State;
            viewModel.ReservationDate = model.ReservationDate;
            viewModel.Description = model.Description;
            viewModel.IsPayed = model.Payed;
            viewModel.IsTeam = model.IsTeam;
            viewModel.User = null;

            if(model.IsActive && model.State != 0 && model.User != null)
            {
                viewModel.User = new SeatingViewModelItem.SeatingUser()
                {
                    ID = model.UserID,
                    FirstName = model.User.FirstName,
                    LastName = model.User.LastName,
                    Nickname = model.User.Nickname,
                    Email = model.User.Email
                };
            }
        }
    }

    public static class SeatingConverter
    {
        public static SeatingListViewModel FilterList(SeatingArgsRequest args)
        {
            SeatingListViewModel result = new SeatingListViewModel(args);

            List<Seat> filteredSeats = SeatDataController.FilterList(args);

            result.Pagination.TotalItemsCount = filteredSeats.Count;

            filteredSeats = filteredSeats.Skip(args.Pagination.ItemsPerPage * args.Pagination.CurrentPage)
                                         .Take(args.Pagination.ItemsPerPage).ToList();

            result.Data = filteredSeats.ConvertAll(x => {
                var vm = new SeatingViewModelItem();
                vm.FromModel(x);
                return vm;
            });

            return result;
        }
    }
}