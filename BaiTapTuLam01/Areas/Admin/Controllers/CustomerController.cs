using Microsoft.AspNetCore.Mvc;

namespace BaiTapTuLam01.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CustomerController : AdminControllerBase
    {
        protected override string PageTitle => "Khách hàng";
    }
}
