using App.Data.Entity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace App.Doctor.Controllers
{
    [Authorize(Roles = "Doctor")]
    public class DischargedPatientsController : Controller
    {
        private readonly HttpClient _httpClient;
        private readonly string _apiAddress;
        public DischargedPatientsController(HttpClient httpClient, IConfiguration configuration)
        {
            _httpClient = httpClient;
            var rootUrl = configuration["Api:RootUrl"];
            _apiAddress = rootUrl + configuration["Api:Patients"]; 
        }
        public async Task<ActionResult> Index()
        {

            int? userId = HttpContext.Session.GetInt32("userId");
            var allPatients = await _httpClient.GetFromJsonAsync<List<Patient>>(_apiAddress);
            var doctorsPatients = allPatients?.Where(p => p.DoctorId == userId && p.IsDischarged).ToList();

            return View(doctorsPatients);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Remove(int id, Patient collection)
        {
            try
            {
                var model = await _httpClient.GetFromJsonAsync<Patient>(_apiAddress + "/" + id);
                if (model != null)
                {
                    model.IsDischarged = false;
                    var response = await _httpClient.PutAsJsonAsync(_apiAddress + "/" + id, model);
                    if (response.IsSuccessStatusCode)
                    {
                        TempData["Message"] = "<div class='alert alert-success'>The Job is Done Sir!</div>";
                        return RedirectToAction(nameof(Index));
                    }
                }
            }
            catch
            {
                return View();
            }
            TempData["Message"] = "<div class='alert alert-danger'>Error!</div>";
            return RedirectToAction(nameof(Index));
        }
    }
}

