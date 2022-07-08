using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    [Table("Todo")]
    [Comment("List of all todo items")]
    public class TodoItemDto: BaseEntity
    {
        [Column("id", Order = 0)]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        [Required]
        [Column("name", Order = 1)]
        public string Name { get; set; } = null!;

        [Required]
        [Column("is_complete", Order = 2)]
        public bool IsComplete { get; set; }

        [Required]
        [Column("is_deleted", Order = 3)]
        public bool IsDeleted { get; set; }
    }
}
