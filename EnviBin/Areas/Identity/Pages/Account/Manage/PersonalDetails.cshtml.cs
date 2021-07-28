using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EnviBin.Web.Site.Areas.Identity.Pages.Account
{
    [Authorize]
    public class PersonalDetailsModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
