using _2ndMVcRepository.AppDbContext;
using _2ndMVcRepository.Interface.Manager;
using _2ndMVcRepository.Manager;
using _2ndMVcRepository.Models;
using Microsoft.AspNetCore.Mvc;

namespace _2ndMVcRepository.Controllers
{
    public class UserController : Controller
    {
        ApplicationDbContext _dbContext;
        IUserManager _userManager;
        public UserController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
            _userManager = new UserManager(_dbContext);

        }
        public IActionResult Index()
        {
            try
            {
                var Result=_userManager.GetAll().ToList();
                return View(Result);

            }catch(Exception ex)
            {
                return View(ex.Message);

            }
           
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddUser(User user)
        {
            try
            {
                string mgs = "";

                bool Result=_userManager.Add(user);
                if (Result)
                {
                    return Redirect("Index");
                }
                else
                {
                    mgs = "User Save Failed";

                }
                ViewBag.mgs = mgs;

                return View();


            }catch(Exception ex)
            {
                return View(ex.Message);
            }

        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            try
            {
                var Result=_userManager.GetById(id);
                if (Result == null)
                {
                    return NotFound();
                }
                return View(Result);

            }catch(Exception ex)
            {
                return View(ex.Message);
            }

        }
        [HttpPost]
        public IActionResult Edit(User user)
        {
            try
            {
                bool IsUpdate =_userManager.Update(user);
                if (IsUpdate)
                {
                    return RedirectToAction("index");
                }
                return View(user);

            }catch(Exception ex)
            {
                return View(ex.Message);
            }

        }
        [HttpGet]
        public IActionResult Details(int id)
        {
            try
            {
                var Result = _userManager.GetById(id);
                if(Result == null)
                {
                    return NotFound();
                }
                return View(Result);

            }
            catch (Exception ex)
            {
                return View(ex.Message);
            }
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            try
            {
                var Res = _userManager.GetById(id);
                if (Res == null)
                {
                    return NotFound();
                }
                return View(Res);

            }
            catch (Exception ex)
            {
                return View(ex.Message);
            }
        }
        [HttpPost]
        public IActionResult userDelete(User user)
        {
            try
            {
                bool IsDelete=_userManager.Delete(user);
                if (IsDelete)
                {
                    return Redirect("Index");
                }
                return View(user);

            }
            catch (Exception ex)
            {
                return View(ex.Message);
            }
        }
    }
}
