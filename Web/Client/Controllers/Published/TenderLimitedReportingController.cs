﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Kapitalist.Data.Models.DTO;
using Kapitalist.Services.Prozorro.Providers;
using Kapitalist.Web.Client.ViewModels.Published;


namespace Kapitalist.Web.Client.Controllers.Published
{

    [Authorize]
    [RoutePrefix("tenderLimitedReporting")]
    public class TenderLimitedReportingController : BasePublishedController
    {
        private ITenderProvider TenderProvider { get; }

        public TenderLimitedReportingController(ITenderProvider tenderProvider)
        {
            TenderProvider = tenderProvider;
        }
      

        [Route("tender/{tenderGuid:guid}/edit")]
        [HttpGet]
        public async Task<ActionResult> EditTender(Guid tenderGuid)
        {
            TenderDTO tender = await TenderProvider.GetTender(tenderGuid);

            var viewModel = new TenderLimitedReportingViewModel(tender);
            return View(viewModel);
        }

        [Route("tender/{tenderGuid:guid}/edit")]
        [ValidateAntiForgeryToken]
        [HttpPost]
        public async Task<ActionResult> EditTender(TenderLimitedReportingViewModel viewModel)
        {
            if (!ModelState.IsValid)
                return View(viewModel);

            var tenderDTO = viewModel.ToDTO();
            await TenderProvider.EditTender(tenderDTO);
            return RedirectToAction("Info", "TenderInfo", new {tenderGuid = tenderDTO.Guid});
        }
    }
}