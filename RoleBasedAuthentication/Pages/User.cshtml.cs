using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RoleBasedAuthentication.Models;

namespace RoleBasedAuthentication.Pages
{

    [Authorize]
    public class UserModel : PageModel
    {

        private readonly UserManager<ApplicationUsers> userManager;

        public ApplicationUsers? appUser;
        public UserModel( UserManager<ApplicationUsers> userManager) 
        {
            this.userManager = userManager;
        }  

        public void OnGet()
        {
            var task = userManager.GetUserAsync(User);
            task.Wait();
            appUser = task.Result;
        }
    }
}
