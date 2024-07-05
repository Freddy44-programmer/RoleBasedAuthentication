using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RoleBasedAuthentication.Pages.Client
{
    [Authorize(Roles = "client")]
    public class ClientDashboardModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
