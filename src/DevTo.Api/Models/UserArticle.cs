﻿using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Forem.Api.Models
{
	public class UserArticle : Article
	{
		[JsonProperty("page_views_count")]
		public int NumberOfPageViews { get; set; }
	}
}
