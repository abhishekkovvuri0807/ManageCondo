using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ManageCondo.DomainLayer
{
    [Table("Property")]
    public class Property
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Required]
        [StringLength(1000)]
        public string Address { get; set; }

        [StringLength(255)]
        public string Email { get; set; }

        [StringLength(1000)]
        public string Description { get; set; }


        [StringLength(255)]
        public string Status { get; set; }


    }
}
