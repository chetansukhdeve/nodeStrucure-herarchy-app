using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebTreeHierarchyApp.Models
{
    public class Node
    {
        [Key]
        public int NodeId { get; set; }
        [Required]
        [DisplayName("Node Name")]
        public string NodeName { get; set; }
        public int? ParentNodeId { get; set; }
        public bool IsActive { get; set; }
        public DateTime StartDate { get; set; }
    }
}
