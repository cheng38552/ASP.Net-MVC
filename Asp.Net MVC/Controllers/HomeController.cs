using System.Collections.Generic;
using System.Web.Mvc;
namespace OnlineGame.Web.Controllers
{
    public class HomeController : Controller
    {
        //// GET: Home
        //public string Index()
        //{
        //    return "Hello";
        //}
        ////http://localhost/OnlineGame.Web/home/index/aa?name=bbb
        ////http://localhost/OnlineGame.Web/home/index/aa?name2=bbb
        //public string Index(string id)
        //{
        //    string queryString = Request.QueryString["name"];
        //    return $"Hey, Id={id} , name={queryString}";
        //}
        ////http://localhost/OnlineGame.Web/home/index/aa?name=bbb
        ////http://localhost/OnlineGame.Web/home/index/aa?name2=bbb
        //public string Index(string id, string name)
        //{
        //    // return string.Format("Hey, Id ={0} , name ={1}", id, name);
        //    return $"Hey, Id ={id} , name ={name}";
        //}
        //public List<string> Index()
        //{
        //    return new List<string>
        //    {
        //        "Name01",
        //        "Name02",
        //        "Name03"
        //    };
        //    // Return System.Collections.Generic.List`1[System.String]
        //    // This is Wrong.
        //}
        //public ActionResult Index()
        //{
        //    return View();
        //}
        //public ActionResult Index()
        //{
        //    ViewBag.Names = new List<string>
        //        {
        //            "Name01",
        //            "Name02",
        //            "Name03"
        //        };
        //    return View();
        //}
        public ActionResult Index()
        {
            ////1.
            //ViewBag.Names = new List<string>
            //{
            //    "ViewBag.Names01",
            //    "ViewBag.Names02",
            //    "ViewBag.Names03"
            //};
            ////2.
            //ViewData["Names"] = new List<string>
            //{
            //    "ViewData[\"Names\"]01",
            //    "ViewData[\"Names\"]02",
            //    "ViewData[\"Names\"]03"
            //};
            ////3.
            //ViewBag.Names = new List<string>
            //{
            //    "ViewBag.Names01",
            //    "ViewBag.Names02",
            //    "ViewBag.Names03"
            //};
            //ViewData["Names"] = new List<string>
            //{
            //    "ViewData[\"Names\"]01",
            //    "ViewData[\"Names\"]02",
            //    "ViewData[\"Names\"]03"
            //};
            //4.
            ViewBag.Names = new List<string>
            {
                "ViewBag.Names01",
                "ViewBag.Names02",
                "ViewBag.Names03"
            };
            ViewData["Names2"] = new List<string>
            {
                "ViewData[\"Names\"]01",
                "ViewData[\"Names\"]02",
                "ViewData[\"Names\"]03"
            };
            return View();
        }
        public string GetStringA()
        {
            return "AAAAAA";
        }
    }
}

/*
1.
When we try to return a list of data,
E.g.
return new List<string>
{
    "Name01",
    "Name02",
    "Name03"
};
Then, it will only display the data type of the variable
E.g.
System.Collections.Generic.List`1[System.String]
This is not what we want,
thus, we need a view to display the data in the format we want.
2.
//public ActionResult Index()
//{
//    return View();
//}
ViewResult extend ViewResultBase
ViewResultBase extend ActionResult.
Thus, you can return View()
3.
In Home/HomeController.cs
//ViewBag.Names = new List<string>
//{
//    "ViewBag.Names01",
//    "ViewBag.Names02",
//    "ViewBag.Names03"
//};
//ViewData["Names2"] = new List<string>
//{
//    "ViewData[\"Names\"]01",
//    "ViewData[\"Names\"]02",
//    "ViewData[\"Names\"]03"
//};
In Views/HomeIndex.cshtml
//@foreach (string strNames1 in ViewBag.Names)
//{
//    <li>@strNames1</li>
//}
//<br/>
//<br/>
//@foreach (string strNames2 in (List<string>) ViewData["Names2"])
//{
//    <li>@strNames2</li>
//}
Both ViewData and ViewBag can pass values from Controller to View.
Both ViewData and ViewBag allow an object to have properties dynamically added to it.
Because of dynamic feature,
both ViewData and ViewBag does not provide compile time error checking.
Thus, it is very easy to get Null Reference Error
if miss misspells the property name or key name.
*/