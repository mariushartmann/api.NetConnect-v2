﻿using api.NetConnect.DataControllers;
using api.NetConnect.data.ViewModel.Profile;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using api.NetConnect.Converters;

namespace api.NetConnect.Controllers
{
    public class ProfileController : ApiController
    {
        [HttpGet]
        public IHttpActionResult GetItem(Int32 id)
        {
            ProfileViewModel viewmodel = new ProfileViewModel();

            try
            {
                viewmodel.Data.FromModel(UserDataController.GetItem(id));
            }
            catch(Exception ex)
            {
                viewmodel.Success = false;
                viewmodel.AddDangerAlert("Ein unerwarteter Fehler is aufgetreten.");
                viewmodel.AddDangerAlert(ex.Message);
            }

            return Ok(viewmodel);
        }
    }
}
