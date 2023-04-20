using System;
using System.Collections.Generic;

namespace ThirdMVCAppDemo.DAL;

public partial class Gender
{
    public int Id { get; set; }

    public string? Text { get; set; }

    public virtual ICollection<User> Users { get; } = new List<User>();
}
