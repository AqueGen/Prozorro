﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kapitalist.Data.Models;
using Kapitalist.Data.Models.Interfaces;

namespace Kapitalist.Data.Store.Models
{
	public class DraftClassification : BaseClassification, IClassification
	{
		public DraftClassification()
		{
		}

		public DraftClassification(BaseClassification classification)
			: base(classification)
		{
		}

		[Key]
		public int InternalId { get; set; }

		[Required]
		public int ItemId { get; set; }

		public virtual DraftItem Item { get; set; }
	}
}
