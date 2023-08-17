using App.Data.Entity;
using App.Web.Mvc.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace App.Web.Mvc.Controllers
{
    public class PostCommentsController : Controller
    {
        private readonly HttpClient _httpClient;
   
        private readonly string _apiAddressPostComments;

        public PostCommentsController(HttpClient httpClient, IConfiguration configuration)
        {
            _httpClient = httpClient;
            var rootUrl = configuration["Api:RootUrl"];
         
            _apiAddressPostComments = rootUrl + configuration["Api:PostComments"];
        }
        // GET: PostCommentsController/Create
        public ActionResult Create(int id)
        {
            
            return View();
        }

        // POST: PostCommentsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(int id,PostComment postComment) // Bu manevra bize 51 yıla mal olacak...
        {
            try
            {
                postComment.PostId = id;
                //postComment.PostId = id;

                //List<DepartmentPost> model = await _httpClient.GetFromJsonAsync<List<DepartmentPost>>(_apiAddress);

                //List<DepartmentPost> viewModel = model?.Where(d => d.DepartmentId == id).ToList();

                //ViewBag.PostId = new SelectList(viewModel, "Id", "Title");
                int? userId = HttpContext.Session.GetInt32("userId");
                if (userId != null)
                {
                    postComment.UserId = userId;
                }

                var response = await _httpClient.PostAsJsonAsync(_apiAddressPostComments, postComment);
                if (response.IsSuccessStatusCode)
                {

                    return RedirectToAction("Index", "Home");

                }
                TempData["Message"] = "<div class='alert alert-danger'>Error, Please Try Again! </div>";




                return View(postComment);
            }
            catch
            {


                ModelState.AddModelError("", "Your Comment cannot sended. Please Try Again!");
                return RedirectToAction("Index", "Home");
            }
        }


    }
}
