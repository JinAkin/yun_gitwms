/*******************************************************************************
 * Copyright (C) Git Corporation. All rights reserved.
 *
 * Author: 代码工具自动生成
 * Create Date: 2016-03-03 22:07:01
 * Blog: http://www.cnblogs.com/qingyuan/ 
 * Copyright:  
 * Description: Git.Framework
 * 
 * Revision History:
 * Date         Author               Description
 * 2016-03-03 22:07:01
*********************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Git.Framework.ORM;
using Git.Framework.MsSql;
using Git.Storage.Entity.Sys;
using Git.Storage.IDataAccess.Sys;

namespace Git.Storage.DataAccess.Sys
{
	public partial class ResourceDataAccess : DbHelper<ResourceEntity>, IResource
	{
		public ResourceDataAccess()
		{
		}

	}
}
