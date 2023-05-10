using System.Data.OleDb;
using System.Web.Mvc;

namespace Web410921896.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            return View();
          @{
                string[] fruits
                = { "蘋果","香蕉","荔枝","鳳梨","西瓜" };
                
            }

        }
    }
}