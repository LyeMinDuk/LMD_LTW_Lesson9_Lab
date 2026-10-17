using BaiTapTuLam01.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;

namespace BaiTapTuLam01.Areas.Admin.Components
{
    /// <summary>
    /// Menu bên trái của Admin. Khai báo menu bằng dữ liệu (1 dòng = 1 mục),
    /// view chỉ việc lặp -> thêm/bớt menu không phải sửa HTML.
    /// </summary>
    public class NavLeftViewComponent : ViewComponent
    {
        private static readonly List<MenuItem> Items = new()
        {
            new("Trang chính", "fas fa-th",           "Dashboard"),
            new("Danh mục",    "fas fa-list",         "Category", HasChildren: true),
            new("Sản phẩm",    "fas fa-box-open",     "Product",  HasChildren: true),
            new("Blogs",       "fas fa-file-alt",     "Blog",     HasChildren: true),
            new("Banner",      "far fa-image",        "Banner",   HasChildren: true),
            new("Khách hàng",  "fas fa-users",        "Customer"),
            new("Đơn hàng",    "fas fa-shopping-cart","Order",    HasChildren: true),
        };

        public IViewComponentResult Invoke()
        {
            // Dùng để tô sáng (active) menu của trang hiện tại
            ViewData["Controller"] = ViewContext.RouteData.Values["controller"]?.ToString();
            ViewData["Action"] = ViewContext.RouteData.Values["action"]?.ToString();
            return View(Items);
        }
    }
}
