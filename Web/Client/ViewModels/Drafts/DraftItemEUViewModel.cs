﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Kapitalist.Data.Models.DTO;
using Kapitalist.Web.Client.Interfaces;
using Kapitalist.Web.Client.ViewModels.Base;

namespace Kapitalist.Web.Client.ViewModels.Drafts
{
    public class DraftItemEUViewModel : BaseItemViewModel, IDraftItemEUViewModel, IValidatableObject
    {
        public DraftItemEUViewModel()
        {
        }

        public DraftItemEUViewModel(Guid tenderGuid) : base(tenderGuid)
        {
        }

        public DraftItemEUViewModel(Guid tenderGuid, ItemDTO item) : base(tenderGuid, item)
        {
            if (item != null)
            {
                Features = item.Features?.Select(m => new FeatureEUViewModel(tenderGuid, m));
                DescriptionEn = item.DescriptionEn;
                Documents = item.Documents?.Select(m => new DraftDocumentViewModel(tenderGuid, m));
            }
        }

        public IEnumerable<IFeatureEUViewModel> Features { get; set; }
        [Required]
        public string DescriptionEn { get; set; }
        public IEnumerable<IDraftDocumentViewModel> Documents { get; set; }

        public override ItemDTO ToDTO()
        {
            var item = base.ToDTO();
            item.DescriptionEn = DescriptionEn;
            return item;
        }

        public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var errors = base.Validate(validationContext).ToList();


            if (ProcurementMethodType == Data.Models.Consts.ProcurementMethodType.ABOVE_THRESHOLD_EU
                || ProcurementMethodType == Data.Models.Consts.ProcurementMethodType.ABOVE_THRESHOLD_UA
                || ProcurementMethodType == Data.Models.Consts.ProcurementMethodType.NEGOTIATION
                || ProcurementMethodType == Data.Models.Consts.ProcurementMethodType.NEGOTIATION_QUICK
                || ProcurementMethodType == Data.Models.Consts.ProcurementMethodType.REPORTING
                || ProcurementMethodType == Data.Models.Consts.ProcurementMethodType.ABOVE_THRESHOLD_UA_DEFENSE)
            {
                if (DeliveryDate?.EndDate == null)
                {
                    errors.Add(new ValidationResult("Повинна бути вказана хоча б endDate дата.", new[] { "DeliveryDate.EndDate" }));
                }
                if (DeliveryAddress.IsEmpty())
                {
                    errors.Add(new ValidationResult("Адреса або місце доставки повинні бути заповнені", new[]
                {
                    "DeliveryAddress.Country",
                    "DeliveryAddress.Locality",
                    "DeliveryAddress.PostalCode",
                    "DeliveryAddress.Region",
                    "DeliveryAddress.Street",
                }));
                }
            }

            return errors;
        }
    }
}