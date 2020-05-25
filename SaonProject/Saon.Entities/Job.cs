using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Saon.Entities
{
    public class Job
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdJob { get; set; }
        
        [StringLength(64) ]
        [Required]
        public string JobTitle { get; set; }

        [StringLength(256)]
        [Required]
        public string Description { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; }
        [Required]
        public DateTime ExpiredAt { get; set; }
    }
}
