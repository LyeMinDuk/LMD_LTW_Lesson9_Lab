using Microsoft.AspNetCore.Mvc;

namespace BaiTapTuLam01.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : AdminControllerBase
    {
        protected override string PageTitle => "Sản phẩm";
    }
}
