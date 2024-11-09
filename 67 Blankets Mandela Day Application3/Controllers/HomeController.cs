using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static _67_Blankets_Mandela_Day_Application3.Models.AmbassadorModel;

namespace _67_Blankets_Mandela_Day_Application3.Controllers
{

    public class HomeController : Controller
    {
        private const string AdminUsername = "admin";
        private const string AdminPassword = "adminpassword";
        private static List<Ambassador> ambassador = new List<Ambassador>();


        public ActionResult Login()
        {
            return View();
        }


        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

      
            public ActionResult Shop()
            {
                // Logic to retrieve products or any other data you need
                return View(); // Make sure there's a corresponding view named 'Shop.cshtml'
            }
        public ActionResult Checkout()
        {
            return View();
        }

        public ActionResult Ambassador()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SubmitAmbassadorForm(Ambassador model)
        {
            // Store the form data in the session
            Session["Ambassador"] = model;

            // Redirect to the Admin page
            return RedirectToAction("Admin");
        }

        public ActionResult Donation()
        {
            return View();
        }

        public ActionResult Donor()
        {
            return View();
        }


        public ActionResult Events ()
        {
            return View();
        }



       
        public ActionResult Admin_Login(string username, string password)
        {
            // Replace this with your actual user validation logic
            if (username == "admin" && password == "password123") // Example credentials
            {
                // Redirect to admin dashboard on successful login
                return RedirectToAction("Admin", "Home");
            }
            else
            {
                // Set error message and return to login view
                ViewBag.ErrorMessage = "Invalid username or password.";
                return View();
            }
        }

        // Admin dashboard action
        [Authorize] // Optional: Add authorization if needed
        public ActionResult Admin()
        {
            ViewBag.AdminUsername = "Pera@gmail.com";
            var ambassadorFormData = Session["Ambassador"] as Ambassador;
            return View("Admin", ambassador); // Return your admin view here
        }

        public ActionResult ApproveForm(int id)
        {
            var form = ambassador.FirstOrDefault(f => f.Id == id);
            if (form != null)
            {
                form.Status = "Approved";
            }
            return RedirectToAction("Admin");
        }

        public ActionResult RejectForm(int id)
        {
            var form = ambassador.FirstOrDefault(f => f.Id == id);
            if (form != null)
            {
                form.Status = "Rejected";
            }
            return RedirectToAction("Admin");
        }
        // Log out and clear admin session
        public ActionResult Logout()
        {
            Session.Clear();
            return RedirectToAction("Login");
        }
        public ActionResult Thank_you_Check()
        {
            return View();
        }
    }


    
}