namespace BaiTapTuLam01.Areas.Admin.Models
{
    /// <summary>Một mục trong menu bên trái của trang quản trị.</summary>
    /// <param name="Title">Tên hiển thị</param>
    /// <param name="Icon">Class icon Font Awesome, ví dụ "fas fa-th"</param>
    /// <param name="Controller">Controller trong area Admin mà mục này trỏ tới</param>
    /// <param name="HasChildren">true = menu cha có 2 mục con: Danh sách / Thêm mới</param>
    public record MenuItem(string Title, string Icon, string Controller, bool HasChildren = false);
}
