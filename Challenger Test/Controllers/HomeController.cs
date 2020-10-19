﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace Challenger_Test.Controllers
{
	public class HomeController : Controller
	{
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

		public async Task<string> GetEmployee()
		{

			var httpClient = new HttpClient();
			var json = await httpClient.GetStringAsync("http://masglobaltestapi.azurewebsites.net/api/Employees");

			return View();
		}
	}
}