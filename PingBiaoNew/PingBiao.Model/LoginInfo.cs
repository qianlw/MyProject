//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace PingBiao.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class LoginInfo
    {
        public int ID { get; set; }
        public System.DateTime CreateTime { get; set; }
        public System.Guid LoginToken { get; set; }
        public System.DateTime LastAccessTime { get; set; }
        public int UserID { get; set; }
        public string LoginName { get; set; }
        public string BusinessPermissionString { get; set; }
        public string ClientIP { get; set; }
        public int EnumLoginAccountType { get; set; }
    }
}
