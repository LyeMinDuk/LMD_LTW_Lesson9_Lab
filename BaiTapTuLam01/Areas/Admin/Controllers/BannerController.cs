using Microsoft.AspNetCore.Mvc;

namespace BaiTapTuLam01.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BannerController : AdminControllerBase
    {
        protected override string PageTitle => "Banner";
    }
}
