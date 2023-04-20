using System;
using System.Collections.Generic;

namespace ThirdMVCAppDemo.DAL;

public partial class User
{
    public int Id { get; set; }

    public string? Email { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public int? GenderId { get; set; }

    public string? MobileNumber { get; set; }

    public string? Password { get; set; }

    public int? AadharNumber { get; set; }

    public virtual Gender? Gender { get; set; }
}
