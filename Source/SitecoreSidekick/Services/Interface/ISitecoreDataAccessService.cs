﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sitecore.Data.Items;
using SitecoreSidekick.Models;

namespace SitecoreSidekick.Services.Interface
{
	public interface ISitecoreDataAccessService
	{
		ScsSitecoreItem GetItem(string id);
	}
}
