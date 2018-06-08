using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Memberships.Entities
{
    [Table("Selection") ] //nazwa tabeli nie bedzie mnoga
    public class Section
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] //autonumerowanie
        public int Id { get; set; }
        [MaxLength(255)] 
        [Required]//nie moze być puste
        public string Title { get; set; }
    }
}