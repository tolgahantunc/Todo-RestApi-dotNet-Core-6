using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    public abstract class BaseEntity
    {
        [Required]
        [Column("created_date", TypeName = "DateTime2")]
        public DateTime CreatedDate { get; set; } = DateTime.Now;

        [Required]
        [Column("updated_date", TypeName = "DateTime2")]
        public DateTime UpdatedDate { get; set; } = DateTime.Now;
    }
}
