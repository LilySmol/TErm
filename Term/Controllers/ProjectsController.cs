using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Redmine.Net.Api;
using Redmine.Net.Api.Types;
using System.Collections.Specialized;

namespace Term.Controllers
{
    public class ProjectsController : Controller
    {
        private string host = "http://127.0.0.1/redmine/";
        private string apiKey = "";
        private List<string> projectList = new List<string>();

        public ActionResult Projects()
        {
            var manager = new RedmineManager(host, apiKey);
            var parameters = new NameValueCollection { { RedmineKeys.STATUS_ID, RedmineKeys.ALL } };
            foreach (var issue in manager.GetObjects<Issue>(parameters))
            {
                projectList.Add(issue.Project.Name);
            }
            ViewBag.Entries = projectList;
            return View();
        }
    }
}