using Microsoft.AspNetCore.Mvc;

namespace BaiTapTuLam01.Areas.Admin.Controllers
{
    /// <summary>
    /// Lớp nền cho các controller quản trị chưa có chức năng.
    /// Ở Bài 2 (CRUD) chỉ cần `override` Index/Create (hoặc viết action riêng) là xong.
    /// </summary>
    public abstract class AdminControllerBase : Controller
    {
        protected abstract string PageTitle { get; }

        public virtual IActionResult Index() => View("_ComingSoon", PageTitle);

        public virtual IActionResult Create() => View("_ComingSoon", $"Thêm mới {PageTitle.ToLower()}");
    }
}
