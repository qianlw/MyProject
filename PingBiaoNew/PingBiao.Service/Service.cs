 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PingBiao.IService;

namespace PingBiao.Service
{
	public partial class LoginInfo : BaseService<PingBiao.Model.LoginInfo>,ILoginInfo
    {
		
    }
	public partial class PingBiao_BiaoDuan : BaseService<PingBiao.Model.PingBiao_BiaoDuan>,IPingBiao_BiaoDuan
    {
		
    }
	public partial class PingBiao_BiaoDuanExt : BaseService<PingBiao.Model.PingBiao_BiaoDuanExt>,IPingBiao_BiaoDuanExt
    {
		
    }
	public partial class PingBiao_BiaoJue : BaseService<PingBiao.Model.PingBiao_BiaoJue>,IPingBiao_BiaoJue
    {
		
    }
	public partial class PingBiao_Eval_BaojiaMark : BaseService<PingBiao.Model.PingBiao_Eval_BaojiaMark>,IPingBiao_Eval_BaojiaMark
    {
		
    }
	public partial class PingBiao_Eval_BiaoJiaBJB : BaseService<PingBiao.Model.PingBiao_Eval_BiaoJiaBJB>,IPingBiao_Eval_BiaoJiaBJB
    {
		
    }
	public partial class PingBiao_KaiBiaoTouBiao : BaseService<PingBiao.Model.PingBiao_KaiBiaoTouBiao>,IPingBiao_KaiBiaoTouBiao
    {
		
    }
	public partial class PingBiao_PW_LoginInfo : BaseService<PingBiao.Model.PingBiao_PW_LoginInfo>,IPingBiao_PW_LoginInfo
    {
		
    }
	public partial class PingBiao_Pw_Mark : BaseService<PingBiao.Model.PingBiao_Pw_Mark>,IPingBiao_Pw_Mark
    {
		
    }
}