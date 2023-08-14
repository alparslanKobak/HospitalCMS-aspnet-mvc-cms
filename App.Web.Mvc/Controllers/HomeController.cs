﻿using App.Data.Entity;
using App.Web.Mvc.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Diagnostics;
using System.Net.Http;

namespace App.Web.Mvc.Controllers
{
	public class HomeController : Controller
	{
		private readonly string _apiAddress = "http://localhost:5005/api/Appointments";
		private readonly string _apiSettingAddress = "http://localhost:5005/api/Settings";
        private readonly string _apiAddressDepartments = "http://localhost:5005/api/Departments";
        private readonly string _apiAddressDoctors = "http://localhost:5005/api/Doctors";
        private readonly HttpClient _httpClient;

		public HomeController(HttpClient httpClient)
		{
			_httpClient = httpClient;
		}

		public async Task<IActionResult> Index()
		{
			
            ViewBag.DepartmentId = new SelectList(await _httpClient.GetFromJsonAsync<List<Department>>(_apiAddressDepartments), "Id", "Name");

			return View();
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<ActionResult> Create(Appointment collection)
		{
			try
			{
				var response = await _httpClient.PostAsJsonAsync(_apiAddress, collection);
				if (response.IsSuccessStatusCode)
				{
					TempData["Message"] = "<div class='alert alert-success'>Your Appointment has been created... Thank you for choosing us</div>";
					return RedirectToAction("Index", "Home");

				}
				TempData["Message"] = "<div class='alert alert-success'>Error, Please Try Again! </div>";




				return View(collection);
			}
			catch
			{


				ModelState.AddModelError("", "Your Appointment cannot sended. Please Try Again!");
				return View(collection);
			}
		}

		[HttpGet]
		public async Task<JsonResult> LoadDoctor(int departmentId)
        {
			try
			{
				var doctorlist = await _httpClient.GetFromJsonAsync<List<Doctors>>(_apiAddressDoctors);
				var newDoctors = doctorlist?.Where(d => d.DepartmentId == departmentId).ToList();
				return Json(new SelectList(newDoctors, "Id", "FullName"));
			}
			catch (Exception ex)
			{
				return Json(new { success = false, message = ex.Message });
			}
		}


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}