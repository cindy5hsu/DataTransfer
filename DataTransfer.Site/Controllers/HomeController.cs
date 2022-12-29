using DataTransfer.Site.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DataTransfer.Site.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			return View();
		}

		public ActionResult P010(string userName) {
			ViewData["userName"] = userName;
			return View();
		}

		public ActionResult P015()
		{
			var model = new MemberVM { Id=99, Name="Allen"};

			// ViewData.Model 可以用來存放 view page 的model, 不過比較少人這樣寫
			ViewData.Model = model;
			return View();

			// 這是比較常見的寫法
			//return View(model); 
		}

		public ActionResult P020(string userName, bool gender)
		{
			ViewData["userName"] = userName;
			ViewData["USERNAME"] = "Simon";
			ViewBag.Gender = gender;

			return View();
		}

		public ActionResult P030(string userName) {
			// 將傳入的userName 存放在 TempData
			TempData["userName"] = userName;

			if (string.IsNullOrEmpty(userName)) {
				TempData["err"] = "userName 必填";
				return RedirectToAction("P030Err");
			}

			return View();
		}

		public ActionResult P030Err() {
			return View();
		}

		public ActionResult P035(string userName) {	
			TempData["err"] = "userName 必填";
			return RedirectToAction("P035Err");
		}

		public ActionResult P035Err() {
			return View();
		}

public ActionResult P037(string userName)
{
	TempData["err"] = "userName 必填";
	return RedirectToAction("P037Err");
}

public ActionResult P037Err()
{
	return View();
}
	}
}