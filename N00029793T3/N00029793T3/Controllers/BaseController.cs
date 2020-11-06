using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using N00029793T3.Models;

namespace N00029793T3.Controllers
{
    public class BaseController : Controller
    {
        private readonly N00029793Context _context;
        public BaseController(N00029793Context context)
        {
            this._context = context;
        }
        protected User LoggedUser()
        {
            var claim = HttpContext.User.Claims.FirstOrDefault();
            var user = _context.Users.Where(o => o.Username == claim.Value).FirstOrDefault();
            return user;
        }
    }
}
