using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PingBiao.Core.Cache;
using PingBiao.Common.Utility;
using PingBiao.Web.Common.Base;

namespace PingBiao.Web
{
    public class AdminCookieContext : CookieContext
    {
        public static AdminCookieContext Current
        {
            get
            {
                return CacheHelper.GetItem<AdminCookieContext>();
            }
        }

        public override string KeyPrefix
        {
            get
            {
                return Fetch.ServerDomain + "_AdminContext_";
            }
        }
    }
}
