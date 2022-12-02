using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FinaleTwo.Models
{
    public class Reminder
    {
        [Key]
        [Column("ReminderID")]
        public int ReminderId { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime ReminderDate { get; set; }

        [StringLength(25)]
        [Unicode(false)]
        public string ModuleName { get; set; } = null!;
    }
}
