using System;
using System.Collections.Generic;

namespace BaiTapTuLam02.Models;

public partial class Banner
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public byte Status { get; set; }

    public int Priority { get; set; }

    public string? Image { get; set; }

    public string? Description { get; set; }
}
