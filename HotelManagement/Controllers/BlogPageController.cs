﻿using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace HotelManagement.Controllers
{
    [AllowAnonymous]
    public class BlogPageController : Controller
    {
        private IBlogService _blogManager;

        public BlogPageController(IBlogService blogManager)
        {
            _blogManager = blogManager;
        }

        public IActionResult Index()
        {
            var values = _blogManager.TGetList().Where(a=>a.BlogStatus == true).ToList();

            ViewBag.Active = "blog";

            return View(values);
        }
        public IActionResult ReadMore(int id)
        {
            var blog = _blogManager.TGetById(id);
            return View(blog);
        }
    }
}
