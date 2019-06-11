using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoreWiki.Data.Entities
{
    public class User
    {
        public User()
        {
            this.Pages = new HashSet<Page>();
        }

        [Key]
        public long Id { get; set; }

        [Required]
        [MaxLength(256)]
        public string AuthId { get; set; }

        [Required]
        [MaxLength(75)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(75)]
        public string LastName { get; set; }

        [Required]
        public DateTime CreatedDate { get; set; }

        [Required]
        public bool IsAuthorized { get; set; }

        [Required]
        public bool IsDeleted { get; set; }

        public virtual ICollection<Page> Pages { get; set; }

        [NotMapped]
        public string FullName => $"{this.FirstName} {this.LastName}";
    }
}