using PingBiao.IService;
using PingBiao.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace PingBiao.Logic
{
    public class HomeController : Controller
    {
        private readonly IPingBiao_BiaoDuan _IPingBiao_BiaoDuan;

        public HomeController(IPingBiao_BiaoDuan iPingBiao_BiaoDuan)
        {
            _IPingBiao_BiaoDuan = iPingBiao_BiaoDuan;
        }
        public ActionResult Index()
        {
            List<PingBiao_BiaoDuan> list = _IPingBiao_BiaoDuan.GetListBy(p => p.BiaoDuanName != null);
            return View(list);
        }
    }
}
