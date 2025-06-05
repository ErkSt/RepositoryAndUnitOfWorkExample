using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TestNetCore.Data;
using TestNetCore.Models;

namespace TestNetCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        //private readonly IPostRepository _postRepository;
        private readonly IUnitOfWork _unitOfWork;

        //public HomeController(ILogger<HomeController> logger, IPostRepository postRepository)
        public HomeController(ILogger<HomeController> logger, IUnitOfWork unitOfWork)
        {
            _logger = logger;

            //ready to use the post repository
            //_postRepository = postRepository;

            _unitOfWork = unitOfWork;
        }

        public async Task<IActionResult> Index()
        {
            var posts = await _unitOfWork.Posts.GetAllAsync();

            //when transactions are used, you can call CompleteAsync to save changes
            return View(posts);
        }
    }
}
