using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using danscoconutsdotnet.Models;

namespace danscoconutsdotnet.Controllers;

public class PostsController : Controller
{
  // private readonly ILogger<PostsController> _logger;

  // public PostsController(ILogger<PostsController> logger)
  // {
  //   _logger = logger;
  // }

  public IActionResult Index()
  {
    return View();
  }

  public IActionResult GetPosts()
  {
    // this should return a list of posts
    return View();
  }

  public IActionResult Create()
  {
    return View();
  }
}
