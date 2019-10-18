using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCoreDatabaseMigration.Models
{
    public class Users
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage ="Cannot exceed 50 characters")]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "Cannot exceed 50 characters")]
        public string LastName { get; set; }

        [Required]
        [RegularExpression(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$", ErrorMessage ="Invalid Email Format")]
        public string Email { get; set; }

        [MaxLength(256,ErrorMessage = "Cannot exceed 256 characters")]
        public string Address { get; set; }

        //Foreign key for Roles
        [ForeignKey("FK_Users_Roles_Id")]
        public int RoleId { get; set; }
        public Roles Role { get; set; }
    }
}
