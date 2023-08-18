using BotanLike.Application.Services.Commands.UserCommands;
using BotanLike.Application.Services.Queries.UserQueries;
using BotanLike.Domain.Entities;
using BotanLike.Domain.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BotanLike.API.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserQueryService _usersQueryService;
        private readonly IUserCommandService _usersCommandService;
        public UserController(IUserQueryService queryService, IUserCommandService commandService)
        {
            _usersCommandService = commandService;
            _usersQueryService = queryService;
        }
        // GET: UserController
        [HttpGet("GetUser")]
        public ActionResult<User> GetUser(int userId)
        {
            return _usersQueryService.GetUser(userId);
        }

        [HttpPut("CreateNewUser")]
        public ActionResult<bool> CreateNewUser([FromBody] NewUserModel newUserModel)
        {
            return _usersCommandService.CreateNewUser(newUserModel);
        }


        //// GET: UserController/Details/5
        //public ActionResult Details(int id)
        //{
        //    return View();
        //}

        //// GET: UserController/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        //// POST: UserController/Create
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create(IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: UserController/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        //// POST: UserController/Edit/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: UserController/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// POST: UserController/Delete/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Delete(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}
