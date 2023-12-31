﻿using App.Data.Entity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace App.Admin.Controllers
{
    [Authorize(Roles = "Doctor")]

    public class AppointmentsController : Controller
    {

        private readonly HttpClient _httpClient;
        private readonly string _apiAddress;
        private readonly string _apiRoles;
        private readonly string _apiDoctorsRoles;
        private readonly string _apiDepartments;

        public AppointmentsController(HttpClient httpClient, IConfiguration configuration)
        {
            _httpClient = httpClient;
            var rootUrl = configuration["Api:RootUrl"];
            _apiAddress = rootUrl + configuration["Api:Appointments"];
            _apiRoles = rootUrl + configuration["Api:Roles"];
            _apiDoctorsRoles = rootUrl + configuration["Api:Doctors"];
            _apiDepartments = rootUrl + configuration["Api:Departments"];
        }

        // GET: AppointmentsController
        public async Task<ActionResult> Index()
        {
            int? userId = HttpContext.Session.GetInt32("userId");
            ViewBag.RoleId = new SelectList(await _httpClient.GetFromJsonAsync<List<Role>>(_apiRoles), "Id", "RoleName");
            ViewBag.DoctorId = new SelectList(await _httpClient.GetFromJsonAsync<List<Doctors>>(_apiDoctorsRoles), "Id", "FullName");
            ViewBag.DepartmentId = new SelectList(await _httpClient.GetFromJsonAsync<List<Department>>(_apiDepartments), "Id", "Name");
            var model = await _httpClient.GetFromJsonAsync<List<Appointment>>(_apiAddress);

            model = model.Where(a => a.DoctorId == userId).ToList();
            return View(model);
        }

        // GET: AppointmentsController/Create
        public async Task<ActionResult> Create()
        {
            ViewBag.RoleId = new SelectList(await _httpClient.GetFromJsonAsync<List<Role>>(_apiRoles), "Id", "RoleName");
            ViewBag.DoctorId = new SelectList(await _httpClient.GetFromJsonAsync<List<Doctors>>(_apiDoctorsRoles), "Id", "FullName");
            ViewBag.DepartmentId = new SelectList(await _httpClient.GetFromJsonAsync<List<Department>>(_apiDepartments), "Id", "Name");
            return View();
        }

        // POST: AppointmentsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(Appointment collection)
        {
            try
            {
                int? userId = HttpContext.Session.GetInt32("userId");
                var doctor = await _httpClient.GetFromJsonAsync<Doctors>(_apiDoctorsRoles + "/" + userId);
                collection.DoctorId = userId;
                collection.DepartmentId = doctor?.DepartmentId;
                var response = await _httpClient.PostAsJsonAsync(_apiAddress, collection);
                if (response.IsSuccessStatusCode)
                {
                    TempData["Message"] = "<div class='alert alert-success'>The Job is Done Sir!</div>";
                    return RedirectToAction(nameof(Index));

                }
            }
            catch (Exception e)
            {
                ModelState.AddModelError("", "Error! : " + e.Message);
            }
            ViewBag.RoleId = new SelectList(await _httpClient.GetFromJsonAsync<List<Role>>(_apiRoles), "Id", "RoleName");
            ViewBag.DoctorId = new SelectList(await _httpClient.GetFromJsonAsync<List<Doctors>>(_apiDoctorsRoles), "Id", "FullName");
            ViewBag.DepartmentId = new SelectList(await _httpClient.GetFromJsonAsync<List<Department>>(_apiDepartments), "Id", "Name");
            return View(collection);
        }

        // GET: AppointmentsController/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            ViewBag.RoleId = new SelectList(await _httpClient.GetFromJsonAsync<List<Role>>(_apiRoles), "Id", "RoleName");
            ViewBag.DoctorId = new SelectList(await _httpClient.GetFromJsonAsync<List<Doctors>>(_apiDoctorsRoles), "Id", "FullName");
            ViewBag.DepartmentId = new SelectList(await _httpClient.GetFromJsonAsync<List<Department>>(_apiDepartments), "Id", "Name");
            var model = await _httpClient.GetFromJsonAsync<Appointment>(_apiAddress + "/" + id);
            return View(model);
        }

        // POST: AppointmentsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(int id, Appointment collection)
        {
            int? userId = HttpContext.Session.GetInt32("userId");
            var doctor = await _httpClient.GetFromJsonAsync<Doctors>(_apiDoctorsRoles + "/" + userId);
            collection.DoctorId = userId;
            collection.DepartmentId = doctor?.DepartmentId;
            var response = await _httpClient.PutAsJsonAsync(_apiAddress + "/" + id, collection);

            if (response.IsSuccessStatusCode)
            {
                TempData["Message"] = "<div class='alert alert-success'>The Job is Done Sir!</div>";
            }
            ViewBag.RoleId = new SelectList(await _httpClient.GetFromJsonAsync<List<Role>>(_apiRoles), "Id", "RoleName");
            ViewBag.DoctorId = new SelectList(await _httpClient.GetFromJsonAsync<List<Doctors>>(_apiDoctorsRoles), "Id", "FullName");
            ViewBag.DepartmentId = new SelectList(await _httpClient.GetFromJsonAsync<List<Department>>(_apiDepartments), "Id", "Name");
            return RedirectToAction(nameof(Index));
        }

        // GET: AppointmentsController/Delete/5
        public async Task<ActionResult> Remove(int id)
        {
            var model = await _httpClient.GetFromJsonAsync<Appointment>(_apiAddress + "/" + id);
            return View(model);
        }

        // POST: AppointmentsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Remove(int id, Appointment collection)
        {
            try
            {
                await _httpClient.DeleteAsync(_apiAddress + "/" + id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
