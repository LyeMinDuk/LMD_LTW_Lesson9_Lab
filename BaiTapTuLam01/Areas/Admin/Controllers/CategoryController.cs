using Microsoft.AspNetCore.Mvc;

namespace BaiTapTuLam01.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : AdminControllerBase
    {
        protected override string PageTitle => "Danh mục";
    }
}
