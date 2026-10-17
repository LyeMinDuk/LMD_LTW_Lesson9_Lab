using Microsoft.AspNetCore.Mvc;

namespace BaiTapTuLam01.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BlogController : AdminControllerBase
    {
        protected override string PageTitle => "Blogs";
    }
}
