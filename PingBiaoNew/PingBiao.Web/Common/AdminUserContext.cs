using System;
using PingBiao.Core.Cache;
using PingBiao.Web.Common.Base;

namespace PingBiao.Web
{
    public class AdminUserContext : UserContext
    {
        public AdminUserContext()
            : base(AdminCookieContext.Current)
        {
        }

        public AdminUserContext(IAuthCookie authCookie)
            : base(authCookie)
        {
        }

        public static AdminUserContext Current
        {
            get
            {
                return CacheHelper.GetItem<AdminUserContext>();
            }
        }
    }
}
