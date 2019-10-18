using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCoreDatabaseMigration.Models
{
    public class Roles
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50,ErrorMessage = "Cannot exceed 50 characters")]
        public string RoleName { get; set; }

        public bool IsActive { get; set; }
    }
}
