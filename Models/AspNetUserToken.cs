using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FinaleTwo.Models;

public partial class AspNetUserToken
{
    [Key]
    public string UserId { get; set; } = null!;

    [StringLength(128)]
    public string LoginProvider { get; set; } = null!;

    [StringLength(128)]
    public string Name { get; set; } = null!;

    public string? Value { get; set; }

    [ForeignKey("UserId")]
    [InverseProperty("AspNetUserTokens")]
    public virtual AspNetUser User { get; set; } = null!;
}
