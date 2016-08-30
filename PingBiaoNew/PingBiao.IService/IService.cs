 
 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PingBiao.IService
{
	public partial interface ILoginInfo : IBaseService<PingBiao.Model.LoginInfo>
    {
    }

	public partial interface IPingBiao_BiaoDuan : IBaseService<PingBiao.Model.PingBiao_BiaoDuan>
    {
    }

	public partial interface IPingBiao_BiaoDuanExt : IBaseService<PingBiao.Model.PingBiao_BiaoDuanExt>
    {
    }

	public partial interface IPingBiao_BiaoJue : IBaseService<PingBiao.Model.PingBiao_BiaoJue>
    {
    }

	public partial interface IPingBiao_Eval_BaojiaMark : IBaseService<PingBiao.Model.PingBiao_Eval_BaojiaMark>
    {
    }

	public partial interface IPingBiao_Eval_BiaoJiaBJB : IBaseService<PingBiao.Model.PingBiao_Eval_BiaoJiaBJB>
    {
    }

	public partial interface IPingBiao_KaiBiaoTouBiao : IBaseService<PingBiao.Model.PingBiao_KaiBiaoTouBiao>
    {
    }

	public partial interface IPingBiao_PW_LoginInfo : IBaseService<PingBiao.Model.PingBiao_PW_LoginInfo>
    {
    }

	public partial interface IPingBiao_Pw_Mark : IBaseService<PingBiao.Model.PingBiao_Pw_Mark>
    {
    }


}