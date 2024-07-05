using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RoleBasedAuthentication.Pages.Seller
{
    [Authorize(Roles = "seller")]
    public class SellerDashboardModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
