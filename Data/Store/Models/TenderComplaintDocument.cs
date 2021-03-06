﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kapitalist.Data.Models;
using Kapitalist.Data.Models.Interfaces;

namespace Kapitalist.Data.Store.Models
{
	public class TenderComplaintDocument : BaseDocument, IDocument
	{
		public TenderComplaintDocument()
		{
		}

		public TenderComplaintDocument(IDocument document)
			: base(document)
		{
		}

		public int Id { get; set; }

		public int ComplaintId { get; set; }

		public virtual TenderComplaint Complaint { get; set; }
	}
}
