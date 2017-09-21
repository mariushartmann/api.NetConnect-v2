﻿using api.NetConnect.data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using api.NetConnect.data.ViewModel.Tournament;
using api.NetConnect.DataControllers;

namespace api.NetConnect.Converters
{
    public static partial class ConverterExtensions
    {
        public static void FromModel(this TournamentViewModelItem viewModel, Tournament model)
        {
            viewModel.Volume = model.Volume;
            viewModel.GameID = model.TournamentGameID;
            viewModel.TeamSize = model.TeamSize;
            viewModel.ChallongeLink = model.ChallongeLink;
            viewModel.Mode = model.Mode;
            viewModel.Start = model.Start;
            viewModel.End = model.End;
            viewModel.IsPauseGame = model.IsPauseGame;
            viewModel.Name = model.TournamentGame.Name;
            viewModel.Icon = model.TournamentGame.Icon;
            viewModel.Rules = model.TournamentGame.Rules;
            viewModel.BattleTag = model.TournamentGame.BattleTag;
            viewModel.Steam = model.TournamentGame.SteamID;

            viewModel.Player = model.TournamentParticipant.ToList().ConvertAll(x => {
                var vm = new TournamentParticipantViewModelItem();
                vm.FromModel(x);
                return vm;
            });

            viewModel.Teams = model.TournamentTeam.ToList().ConvertAll(x => {
                var vm = new TournamentTeamViewModelItem();
                vm.FromModel(x);
                return vm;
            });

            if(model.Partner != null)
                viewModel.Partner.FromModel(model.Partner);

            viewModel.TeilnehmerAnzahl = model.TournamentParticipant.Count;
            viewModel.Teams.ForEach(team => viewModel.TeilnehmerAnzahl += team.Player.Count);
        }

        private static void FromModel(this TournamentTeamViewModelItem viewModel, TournamentTeam model)
        {
            viewModel.ID = model.ID;
            viewModel.Name = model.Name;
            viewModel.HasPassword = !String.IsNullOrEmpty(model.Password);
            viewModel.Player = model.TournamentParticipant.ToList().ConvertAll(x => {
                var vm = new TournamentParticipantViewModelItem();
                vm.FromModel(x);
                return vm;
            });
        }

        private static void FromModel(this TournamentParticipantViewModelItem viewModel, TournamentParticipant model)
        {
            viewModel.ID = model.ID;
            viewModel.FirstName = model.User.FirstName;
            viewModel.LastName = model.User.LastName;
            viewModel.Nickname = model.User.Nickname;
        }

        private static void FromModel(this TournamentViewModelItem.TournamentPartner viewModel, Partner model)
        {
            viewModel.ID = model.ID;
            viewModel.Name = model.Name;
            viewModel.Image = model.Image;
        }
    }
}