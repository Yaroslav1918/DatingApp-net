using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API.Enteties
{
    [Table("Photos")]
    public class Photo
    {
        public int Id { get; set; }
        public required  string Url { get; set; }
        public bool IsMain { get; set; }
        public string? PublicId { get; set; }
        // Navigation properties 
        public int AppUserId { get; set; }
        public AppUser Appuser { get; set; } = null!;

        
    }
}