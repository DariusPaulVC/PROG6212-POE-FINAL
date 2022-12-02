using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FinaleTwo.Models;

[Table("modules")]
public partial class Module
{
    [Key]
    [Column("ModuleID")]
    public int ModuleId { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string ModuleCode { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string ModuleName { get; set; } = null!;

    public int Credits { get; set; }

    public int ClassHours { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime StudyDate { get; set; }

    public int SelfStudyHours { get; set; }

    [Column("UserID")]
    [StringLength(450)]
    public string? UserId { get; set; }

    [Column("SemesterID")]
    public int? SemesterId { get; set; }

    [ForeignKey("SemesterId")]
    [InverseProperty("Modules")]
    public virtual Semester? Semester { get; set; }

    [ForeignKey("UserId")]
    [InverseProperty("Modules")]
    public virtual AspNetUser? User { get; set; }
}
