using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FinaleTwo.Models;

[Table("semester")]
public partial class Semester
{
    [Key]
    [Column("SemesterID")]
    public int SemesterId { get; set; }

    [StringLength(25)]
    [Unicode(false)]
    public string SemesterName { get; set; } = null!;

    public int SemesterWeeks { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime SemesterStartDate { get; set; }

    [Column("UserID")]
    [StringLength(450)]
    public string? UserId { get; set; }

    [InverseProperty("Semester")]
    public virtual ICollection<Module> Modules { get; } = new List<Module>();

    [ForeignKey("UserId")]
    [InverseProperty("Semesters")]
    public virtual AspNetUser? User { get; set; }
}



