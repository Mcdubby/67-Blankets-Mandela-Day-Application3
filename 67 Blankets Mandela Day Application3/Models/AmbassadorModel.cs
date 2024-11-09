using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _67_Blankets_Mandela_Day_Application3.Models
{
    public class AmbassadorModel : Controller
    {
        // GET: AmbassadorModel
        public ActionResult Index()
        {
            return View();
        }

        public class Ambassador
        {
            public int Id { get; set; }
            public string FullName { get; set; }
            public string Email { get; set; }
            public string Phone { get; set; }
            public string DOB { get; set; }
            public string Country { get; set; }
            public string Organization { get; set; }
            public string SocialMedia { get; set; }
            public string Message { get; set; }
            public string Status { get; set; } = "Pending"; // Default to "Pending"

        }

    }
}
