using Microsoft.AspNetCore.Mvc;

namespace BaiTapTuLam01.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class OrderController : AdminControllerBase
    {
        protected override string PageTitle => "Đơn hàng";
    }
}
