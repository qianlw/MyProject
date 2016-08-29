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
        IPingBiao_BiaoDuan _iPingBiao_BiaoDuan=new PingBiao.Service.PingBiao_BiaoDuan();

        public ActionResult Index()
        {
            PingBiao_BiaoDuan testbd = new PingBiao_BiaoDuan();
            testbd.BiaoDuanName = "test666";
            testbd.BiaoDuanNo = "test666";
            _iPingBiao_BiaoDuan.Add(testbd);

            ViewBag.Test = _iPingBiao_BiaoDuan.GetListBy(p => p.BiaoDuanName == "test666").FirstOrDefault().BiaoDuanName;
            return View();

            

        }
    }
}
