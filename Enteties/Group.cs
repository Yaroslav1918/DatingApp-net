using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace API.Enteties
{
    public class Group
    {
        [Key]
        public required string Name { get; set; }
        public ICollection<Connection> Connections { get; set; } = [];
    }
}