using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Flipside_Server.GraphQL
{
    public class Debate
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public User Creator { get; set; }

        [Required]
        public string Resolution { get; set; }

        public string SpiritOfTheResolution { get; set; }

        public ICollection<Argument> Arguments { get; set; } = new List<Argument>();

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime CreatedAt { get; set; }
    }
}
