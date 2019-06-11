using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoreWiki.Data.Entities
{
    [Table("Pages")]
    public class Page
    {
        [Key]
        public long Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Title { get; set; }

        public string Content { get; set; }

        [Required]
        public long ModifiedById { get; set; }

        [ForeignKey("ModifiedById")]
        public virtual User ModifiedBy { get; set; }

        [Required]
        public DateTime ModifiedOn { get; set; }

        [Required]
        public bool IsDraft { get; set; }

        [Required]
        public bool IsApproved { get; set; }
    }
}
